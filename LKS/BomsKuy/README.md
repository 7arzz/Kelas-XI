# 💣 BOMSKUY — Panduan Singkat

> Game Bomberman berbasis HTML Canvas + JavaScript murni.

---

## 🧠 Konsep Dasar

| Bahasa | Fungsi |
|--------|--------|
| **HTML** | Struktur/kerangka halaman |
| **CSS** | Tampilan, warna, ukuran |
| **JavaScript** | Logika & interaktivitas |

**Canvas** = papan gambar HTML. Karakter, bom, musuh, ledakan digambar ulang ~60x/detik menggunakan JS.

---

## 📁 Struktur File

```
BomsKuy/
├── index.html        ← Menu utama (2 tombol pilihan game)
├── bomskuy1.html     ← File game (HTML + CSS + JS dalam 1 file)
├── bomskuy2.html     ← Copy dari bomskuy1 (ganti title saja)
├── README.md
└── Images/           ← Semua aset gambar
    ├── logo.png / logo_white.png / background.jpg
    ├── wall.png / wall_crack.png / bomb.png / tnt.png / ice.png
    ├── heartFull.png / heartGone.png / explosion.png
    ├── char_down/up/left/right.png  (sprite player)
    └── dog_down/up/left/right.png   (sprite musuh)
```

---

## 🗺️ Alur Layar

```
index.html → bomskuy1.html / bomskuy2.html
    [1. WELCOME] → isi username + level → Play
    [2. GAME]    → bermain di canvas
    [3. GAME OVER] → nyawa habis
    [4. LEADERBOARD] → tabel skor
```

Perpindahan layar diatur dengan class CSS `active`:
- Default semua layar: `display: none`
- Layar aktif: `display: block` (via `.screen.active`)
- JS: `showScreen("game")` → hapus `active` semua layar, tambah ke target

---

## TAHAP 0 — Persiapan

1. Buat folder `BomsKuy/` + subfolder `Images/`
2. Salin semua file gambar ke `Images/`
3. Buat 3 file kosong: `index.html`, `bomskuy1.html`, `bomskuy2.html`
4. Buka VS Code → File → Open Folder → pilih `BomsKuy`

---

## TAHAP 1 — index.html

HTML standar dengan `<style>` di `<head>` dan dua tombol `<a>` di `<body>`.

**CSS penting:**
```css
/* Latar gradien ungu gelap, konten di tengah */
body { display: flex; align-items: center; justify-content: center;
       background: linear-gradient(135deg, #0f0c29, #302b63, #24243e); }

/* Tombol dengan efek shimmer saat hover */
.btn { padding: 14px 36px; border-radius: 12px; transition: transform .2s; }
.btn::before { /* cahaya putih bergerak kiri ke kanan saat hover */ }
.btn:hover { transform: translateY(-3px); }
.btn-primary   { background: linear-gradient(135deg, #6c63ff, #e942b8); }
.btn-secondary { background: linear-gradient(135deg, #00c9a7, #0070f3); }
```

**HTML Body:**
```html
<div class="btn-container">
  <a href="bomskuy1.html" class="btn btn-primary"   id="btn-bomskuy1">🚀 Bomskuy 1</a>
  <a href="bomskuy2.html" class="btn btn-secondary" id="btn-bomskuy2">🎮 Bomskuy 2</a>
</div>
```

✅ TEST: Buka `index.html` → 2 tombol di latar ungu gelap.

---

## TAHAP 2 — bomskuy1.html: CSS

**Sistem layar (terpenting):**
```css
.screen        { display: none; position: absolute; top:0; left:0; width:100%; height:100%; }
.screen.active { display: block; }
```

**Layout game:**
```css
#game-area    { position: absolute; top:0; left:0; right:220px; bottom:0; }
#game-canvas  { position: absolute; top:50%; left:50%; transform:translate(-50%,-50%);
                width:705px; height:578px; image-rendering: pixelated; }
#game-sidebar { position: absolute; top:0; right:0; width:220px; height:100%;
                background:#2b2b2b; padding:25px 20px; }
```

**Warna tombol game:**
```css
.btn-dark   { background:#000;    color:#fff; }  /* Play, Instruction */
.btn-orange { background:#cf3708; color:#fff; }  /* Save Score, Play Again */
.btn-blue   { background:#0070ba; color:#fff; }  /* Leaderboards, Reset */
```

---

## TAHAP 3 — bomskuy1.html: HTML (4 Layar)

```html
<!-- Layar 1: Welcome (langsung aktif) -->
<div id="screen-welcome" class="screen active">
  <input type="text" id="input-username" placeholder="Input Username" maxlength="15" autocomplete="off"/>
  <select id="select-level">
    <option value="" disabled selected>Select Level</option>
    <option value="easy">Easy</option>
    <option value="medium">Medium</option>
    <option value="hard">Hard</option>
  </select>
  <button id="btn-play" class="btn btn-dark">Play</button>
  <button id="btn-instruction" class="btn btn-dark">Instruction</button>
</div>

<!-- Layar 2: Game -->
<div id="screen-game" class="screen">
  <div id="game-area"><canvas id="game-canvas"></canvas></div>
  <div id="game-sidebar"><!-- nama, nyawa, skor, waktu --></div>
</div>

<!-- Layar 3: Game Over -->
<div id="screen-gameover" class="screen"><!-- statistik + tombol --></div>

<!-- Layar 4: Leaderboard -->
<div id="screen-leaderboard" class="screen">
  <table class="table-lb"><tbody id="lb-body"></tbody></table>
</div>

<!-- Modal Instruction -->
<div id="modal-instruction" class="modal"><!-- isi instruksi --></div>
```

✅ TEST: Buka `bomskuy1.html` → Welcome Screen dengan form muncul.

---

## TAHAP 4 — JavaScript: Konfigurasi & State

```javascript
const COLS = 11, ROWS = 9, TILE = 64;
const OFFSET_X = 1, OFFSET_Y = 1;

const canvas = document.getElementById("game-canvas");
const ctx    = canvas.getContext("2d");
canvas.width = 705; canvas.height = 578;

const LEVEL_CONFIG = {
  easy:   { bricks: 20, enemies: 1, enemySpeed: 800 },
  medium: { bricks: 26, enemies: 2, enemySpeed: 650 },
  hard:   { bricks: 32, enemies: 3, enemySpeed: 500 },
};

const state = {
  username: "", running: false,
  hearts: 3, walls: 0, tnt: 0, ice: 0,
  time: 0, timerId: null,
  grid: [],            // 0=kosong, 1=batu, 2=brick
  hiddenItems: {},     // { "r,c": "tnt"|"ice"|"heart" }
  droppedItems: {},    // item yang sudah jatuh di lantai
  player: { r:1, c:1, dir:"down", invincibleUntil:0, lastMove:0, speedDelay:170 },
  enemies: [], bombs: [], explosions: [],
};
```

---

## TAHAP 5 — Load Gambar

```javascript
const IMAGES = {};
["background.jpg","wall.png","bomb.png","tnt.png","ice.png",
 "char_down.png","char_up.png","char_left.png","char_right.png",
 "dog_down.png","dog_up.png","dog_left.png","dog_right.png",
 "heartFull.png","heartGone.png","explosion.png","wall_crack.png"].forEach(name => {
  const img = new Image();
  img.src = "Images/" + name;
  IMAGES[name.replace(/\.(png|jpg)$/, "")] = img;
});

function drawImg(key, x, y, w, h) {
  const img = IMAGES[key];
  if (img?.complete && img.naturalWidth > 0) ctx.drawImage(img, x, y, w, h);
}
```

---

## TAHAP 6–15 — JavaScript: Fungsi Utama

| Fungsi | Tugas |
|--------|-------|
| `showScreen(id)` | Berpindah layar (hapus semua `active`, tambah ke target) |
| `startGame()` | Buat grid, spawn player+musuh, mulai timer & game loop |
| `updateSidebar()` | Perbarui nama, nyawa, skor, waktu di sidebar |
| `canMove(r,c)` | Cek apakah posisi (r,c) bisa dimasuki player |
| `handleInput()` | Baca `keys[]`, gerak player tiap `speedDelay` ms |
| `placeBomb()` | Tambah bom ke `state.bombs`, meledak setelah 2500ms |
| `updateBombs()` | Cek waktu ledak → hitung area terkena → hancurkan brick |
| `updateEnemies()` | Gerak musuh (60% mengejar, 40% acak) pakai jarak Manhattan |
| `render()` | `clearRect` → background → brick → item → bom → musuh → player |
| `endGame()` | Hentikan loop, simpan skor ke `localStorage`, tampilkan Game Over |
| `renderLeaderboard()` | Baca `localStorage`, sort (walls desc, time asc), isi tabel HTML |

**Pola grid di startGame:**
```javascript
// Batu di pinggir + posisi (baris genap, kolom genap) = pola labirin Bomberman
if (r===0 || r===ROWS-1 || c===0 || c===COLS-1) return 1;
if (r%2===0 && c%2===0) return 1;
return 0;  // sisanya kosong
```

**Game loop:**
```javascript
function gameLoop() {
  if (!state.running) return;
  handleInput(); updateBombs(); updateEnemies(); render();
  requestAnimationFrame(gameLoop);  // ~60x per detik
}
```

**Simpan & baca skor:**
```javascript
localStorage.setItem("bomskuy_lb", JSON.stringify(lb));
JSON.parse(localStorage.getItem("bomskuy_lb"));
```

---

## TAHAP 16 — bomskuy2.html

1. Buka `bomskuy1.html` → Ctrl+A → Ctrl+C
2. Buka `bomskuy2.html` → Ctrl+V → Simpan
3. Ganti `<title>BOMSKUY</title>` → `<title>BOMSKUY 2</title>`

---

## 🧪 Checklist Testing

| # | Cek | ✓ |
|---|-----|---|
| 1 | `index.html`: 2 tombol di latar ungu | ☐ |
| 2 | Klik Bomskuy 1 → Welcome Screen | ☐ |
| 3 | Instruction → modal muncul; ✕ → tutup | ☐ |
| 4 | Isi username + level → Play → game mulai | ☐ |
| 5 | Arrow/WASD → karakter bergerak | ☐ |
| 6 | Space/Enter → bom muncul & meledak 2.5 detik | ☐ |
| 7 | Brick hancur, skor wall +1 | ☐ |
| 8 | Item (TNT/Ice) muncul setelah brick hancur | ☐ |
| 9 | Musuh bergerak mengejar player | ☐ |
| 10 | Kena ledakan/musuh → nyawa berkurang, player kedip | ☐ |
| 11 | Nyawa 0 → Game Over Screen | ☐ |
| 12 | Save Score → tombol jadi "Saved!" | ☐ |
| 13 | Leaderboards → tabel skor muncul | ☐ |
| 14 | Reset → skor terhapus | ☐ |
| 15 | Play Again → kembali ke Welcome | ☐ |
| 16 | Bomskuy 2 berjalan sama | ☐ |

---

## 🐛 Masalah Umum

| Masalah | Solusi |
|---------|--------|
| Game tidak jalan | Hapus `<!--` dan `-->` di sekitar tag `<script>` |
| Gambar tidak muncul | Cek nama file di `Images/` — huruf besar/kecil beda = error |
| Canvas putih | Pastikan `background.jpg` ada di `Images/`, lalu refresh |
| Player tidak bergerak | Klik dulu di area canvas agar keyboard terdaftar |
| Tombol tidak berfungsi | Periksa ejaan `id` di HTML harus SAMA PERSIS dengan di JS |
| Leaderboard kosong | Selesaikan game dulu, lalu klik Save Score |

---

## 📌 Referensi Tampilan (folder `Example/`)

| File | Layar |
|------|-------|
| `01. Welcome.jpg` | Welcome Screen |
| `02. Instruction.jpg` | Modal Instruction |
| `03–08. Game *.jpg` | Gameplay |
| `09. Gameover.jpg` | Game Over |
| `10. Leaderboards.jpg` | Leaderboard |

---

*Selamat mengerjakan! 💪*
