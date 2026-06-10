# FSM ScriptableObject Modular

Nama: Muhammad Afriza Jein  
Kelas: GJ24A  

## Penjelasan Singkat

Project ini merupakan praktikum implementasi Finite State Machine (FSM) menggunakan ScriptableObject di Unity. Sistem ini digunakan untuk mengatur perilaku enemy berdasarkan state, yaitu Idle, Chase, dan Attack.

Pada project ini, setiap state dibuat terpisah menggunakan ScriptableObject agar struktur program lebih modular, rapi, dan mudah dikembangkan. Enemy akan berada pada state Idle saat player jauh, berpindah ke Chase saat player masuk jarak kejar, dan masuk ke Attack saat player berada dalam jarak serang.

## Fitur

- Enemy memiliki state Idle, Chase, dan Attack
- Menggunakan ScriptableObject sebagai pengelola state
- State dibuat modular dan terpisah
- Enemy dapat berpindah state berdasarkan jarak dengan player

## Tools

- Unity 6.3 LTS
- C#
- GitHub
