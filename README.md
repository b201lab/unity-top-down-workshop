# Pembuatan Game Top Down Menggunakan Unity

[Unity](https://unity.com/) merupakan salah satu [_game engine_](https://en.wikipedia.org/wiki/Game_engine) yang dapat digunakan untuk membuat _game_ secara [_cross platform_](https://en.wikipedia.org/wiki/Cross-platform_software).
Dulunya _game engine_ ini dikenal juga sebagai Unity 3D, karena keunggulan utamanya terletak pada pembuatan _game_ berbasis 3D.
Namun dengan seiringnya waktu, perkembangan _game engine_ ini juga mulai mendukung secara penuh untuk pembuatan game berbasis 2D.
Selain itu, sesuai dengan namanya, Unity, _game engine_ ini mempunyai prinsip penyatuan, dengan adanya sistem _package manager_ serta [_component based architecture_](https://en.wikipedia.org/wiki/Component-based_software_engineering), pembuatan game bisa berjalan lebih cepat dengan mengandalkan _package_ maupun _component_ yang sudah ada tanpa menulis ulang fungsi untuk tiap _component_ yang dibutuhkan.

**Agar workshop pada _hari-h_ berjalan dengan lancar, setiap peserta diharapkan sudah melakukan instalasi Unity secara mandiri pada komputer masing masing**

## Instalasi Unity

Berbeda dengan cara sebelumnya, untuk saat ini instalasi untuk Unity diharuskan melewati program lain yang bernama [Unity Hub](https://docs.unity3d.com/Manual/GettingStartedUnityHub.html).
Unity Hub sendiri merupakan program yang digunakan untuk mengatur akun dan lisensi Unity serta untuk melakukan instalasi Unity Editor pada versi yang berbeda-beda.
> Informasi lebih lanjut mengenai instalasi Unity bisa dilihat [disini](https://docs.unity3d.com/Manual/GettingStartedInstallingUnity.html).

### Instalasi Unity Hub

- Sebelum melakukan instalasi, pastikan spesifikasi komputer anda sudah memenuhi prasyarat minimum sehingga pembuatan _game_ menggunakan Unity nantinya bisa berjalan dengan lancar.
  > Informasi lebih lanjut mengenai spesifikasi minimum Unity bisa dilihat [disini](https://docs.unity3d.com/Manual/system-requirements.html).
- Unduh Unity Hub pada halaman berikut https://unity3d.com/get-unity/download.
- Buka program yang sudah diunduh untuk melakukan instalasi Unity Hub.

### Instalasi Unity Editor

- Buka Unity Hub.
- Sebelum melakukan instalasi Unity Editor, anda akan diminta untuk mengaktifkan lisensi Unity.
- Login menggunakan akun Unity, masuk menu `Preferences`, dan pada bagian `License Management` klik `Activate New License`.
- Pilih `Unity Personal` jika sebelumnya anda belum memiliki lisensi Unity Pro/Plus.
- Setelah selesai, kembali ke menu utama, dan pada bagian `Installs`, klik `Add`.
- Pilih Unity dengan versi [LTS](https://en.wikipedia.org/wiki/Long-term_support) terbaru (`Unity 2019.4`) dan pada bagian `modules` kosongkan semua.
  > Modules bersifat opsional, kebanyakan digunakan untuk _development_ pada platform yang berbeda. Jika dibutuhkan, modules masih bisa ditambahkan setelah instalasi dilakukan.
- Tunggu hingga instalasi selesai.
  > Instalasi akan memakan waktu yang cukup lama, jadi pastikan anda menggunakan internet dengan _bandwith_ yang besar dan kecepatan yang stabil.

### Mencoba Membuat Project Baru

- Untuk memastikan instalasi Unity berjalan dengan lancar, pastikan anda sudah mencoba membuat _project_ baru pada Unity.
- Buka Unity Hub, dan pada bagian `Projects`, klik `New`.
- Pilih `2D` untuk `Templates`, untuk yang lain bisa diisi bebas, kemudian klik `Create`.
- Tunggu proses pembuatan _project_ Unity selesai.
- Setelah muncul jendela Unity Editor, maka instalasi Unity sudah selesai dan siap untuk digunakan.

## Workshop Pembuatan Game

Pada _workshop_ kali ini, kita akan membahas pembuatan game [top down](https://en.wikipedia.org/wiki/Video_game_graphics#Top-down_perspective) menggunakan Unity dari yang paling mendasar sehingga mudah dipahami oleh pemula.
Beberapa bagian pada _workshop_ kali ini akan banyak bersinggungan dengan pemrograman berbasis [C#](https://en.wikipedia.org/wiki/C_Sharp_(programming_language))
dan untuk hal teknis yang bersinggungan dengan Unity-nya langsung hanya akan disinggung secara singkat.
Nantinya selain mendapat bekal pembuatan _game engine_ Unity, peserta juga diharapkan bisa mendapatkan pengetahuan pada dasar pemrograman yang nantinya bisa dipakai di hal lain.

Alur dari pembuatan game top down menggunakan unity adalah sebagai berikut:
1. [Pengenalan Konsep](./Assets/1-Pengenalan-Konsep/README.md)
2. [Gerakan dan Animasi](./Assets/2-Gerakan-dan-Animasi/README.md)
3. [Object Collision](./Assets/3-Object-Collision/README.md)
4. [Pathfinding](./Assets/4-Pathfinding/README.md)
5. [Navigasi Scene](./Assets/5-Navigasi-Scene/README.md)
6. [Game Deployment](./Assets/6-Game-Deployment/README.md)