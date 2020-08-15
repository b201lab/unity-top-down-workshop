# Pembuatan Game Top Down Menggunakan Unity

[Unity](https://unity.com/) merupakan salah satu game engine yang dapat digunakan untuk membuat game secara [cross platform](https://en.wikipedia.org/wiki/Cross-platform_software).
Dulunya game engine ini dikenal juga sebagai Unity 3D, karena keunggulan utamanya terletak pada pembuatan game berbasis 3D.
Namun dengan seiringnya waktu, perkembangan game engine ini juga mulai mendukung secara penuh untuk pembuatan game berbasis 2D.
Selain itu, sesuai dengan namanya, Unity, game engine ini mempunyai prinsip penyatuan, dengan adanya sistem package manager serta [component based architecture](https://en.wikipedia.org/wiki/Component-based_software_engineering), pembuatan game bisa berjalan lebih cepat dengan mengandalkan package/component yang sudah ada tanpa menulis ulang fungsi untuk tiap component yang dibutuhkan.

**Agar workshop pada hari-h berjalan dengan lancar, setiap peserta diharapkan sudah melakukan instalasi unity secara mandiri pada komputer masing masing**

## Instalasi Unity

Berbeda dengan cara sebelumnya, untuk saat ini instalasi untuk Unity diharuskan melewati program lain yang bernama [Unity Hub](https://docs.unity3d.com/Manual/GettingStartedUnityHub.html).
Unity Hub sendiri merupakan program yang digunakan untuk mengatur akun/lisensi Unity serta untuk melakukan instalasi Unity Editor pada versi yang berbeda-beda.
> Info lebih lanjut mengenai instalasi Unity bisa dilihat [disini](https://docs.unity3d.com/Manual/GettingStartedInstallingUnity.html).

### Instalasi Unity Hub

- Sebelum melakukan instalasi, pastikan spesifikasi komputer anda sudah memenuhi prasyarat minimum sehingga pembuatan game menggunakan Unity nantinya bisa berjalan dengan lancar.
  > Info lebih lanjut mengenai spesifikasi minimum unity bisa dilihat [disini](https://docs.unity3d.com/Manual/system-requirements.html).
- Unduh Unity Hub pada halaman berikut https://unity3d.com/get-unity/download.
- Buka program yang sudah diunduh untuk melakukan instalasi Unity Hub.

### Instalasi Unity Editor

- Buka Unity Hub.
- Sebelum melakukan instalasi Unity Editor, anda akan diminta untuk mengaktifkan lisensi Unity.
- Login menggunakan akun Unity, masuk menu `Preferences`, dan pada bagian `License Management` klik `Activate New License`.
- Pilih `Unity Personal` jika sebelumnya anda belum memiliki lisensi Unity Pro/Plus.
- Setelah selesai, kembali ke menu utama, dan pada bagian `Installs`, klik `Add`.
- Pilih Unity dengan versi [LTS](https://en.wikipedia.org/wiki/Long-term_support) terbaru (`Unity 2019.4`) dan pada bagian modules kosongkan semua.
- Tunggu hingga instalasi selesai.
  > Instalasi akan memakan waktu yang cukup lama, jadi pastikan anda menggunakan internet dengan bandwith  yang besar dan kecepatan yang stabil.

### Mencoba Membuat Project Baru

- Untuk memastikan instalasi Unity berjalan dengan lancar, pastikan anda sudah mencoba membuat project baru pada Unity.
- Buka Unity Hub, dan pada bagian `Projects`, klik `New`.
- Pilih `2D` untuk `Templates`, untuk yang lain bisa diisi bebas, kemudian klik `Create`.
- Tunggu proses pembuatan project Unity selesai.
- Setelah muncul windows Unity Editor, maka instalasi Unity sudah selesai dan siap untuk digunakan.

## Workshop Pembuatan Game

Pada workshop kali ini, kita akan membahas pembuatan game [top down](https://en.wikipedia.org/wiki/Video_game_graphics#Top-down_perspective) menggunakan Unity dari yang paling mendasar sehingga mudah dipahami oleh pemula.
Beberapa bagian pada workshop kali ini akan banyak bersinggungan dengan pemrograman berbasis [C#](https://en.wikipedia.org/wiki/C_Sharp_(programming_language))
dan untuk hal teknis yang bersinggungan dengan Unity-nya langsung hanya akan disinggung secara singkat.
Nantinya selain mendapat bekal pembuatan game engine Unity, peserta juga diharapkan bisa mendapatkan pengetahuan pada dasar pemrograman yang nantinya bisa dipakai di hal lain.

Alur dari pembuatan game top down menggunakan unity adalah sebagai berikut:
1. [Pengenalan Konsep](./Assets/1-Pengenalan-Konsep/README.md)
2. [Gerakan dan Animasi](./Assets/2-Gerakan-dan-Animasi/README.md)
3. [Object Collision](./Assets/3-Object-Collision/README.md)
4. [Pathfinding](./Assets/4-Pathfinding/README.md)
5. [Navigasi Scene](./Assets/5-Navigasi-Scene/README.md)
6. [Game Deployment](./Assets/6-Game-Deployment/README.md)