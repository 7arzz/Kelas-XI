package com.example.aplikasipertama

import android.os.Bundle
import androidx.activity.ComponentActivity
import androidx.activity.compose.setContent
import androidx.activity.enableEdgeToEdge
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.padding
import androidx.compose.material3.Scaffold
import androidx.compose.material3.Text
import androidx.compose.runtime.Composable
import androidx.compose.ui.Modifier
import androidx.compose.ui.tooling.preview.Preview
import com.example.aplikasipertama.ui.theme.AplikasiPertamaTheme

class MainActivity : ComponentActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
//        val nama = "Amerta"
//        var ucapan = "Halo " + nama + "Selamat Datang"
//        println(ucapan)

//        val Nama: String = "Ucup"
//        val Umur: Int = 17
//        val Tinggi: Double = 171.8
//        val Belajar: Boolean = true

//        println(Nama)
//        println(Umur)
//        println(Tinggi)
//        println(Belajar)

        sapa(Nama = "Ucup Surucup")

        enableEdgeToEdge()
        setContent {
            AplikasiPertamaTheme {
                Scaffold(modifier = Modifier.fillMaxSize()) { innerPadding ->
                    Greeting(
                        name = "Amerta",
                        modifier = Modifier.padding(innerPadding)
                    )
                }
            }
        }
    }
    fun sapa(Nama: String){
        println("Halo $Nama , selamat belajar Kotlin")
    }

}

@Composable
fun Greeting(name: String, modifier: Modifier = Modifier) {
    Text(
        text = "Hello $name!, welcome to my first application",
        modifier = modifier
    )
}

@Preview(showBackground = true)
@Composable
fun GreetingPreview() {
    AplikasiPertamaTheme {
        Greeting("Android")
    }
}