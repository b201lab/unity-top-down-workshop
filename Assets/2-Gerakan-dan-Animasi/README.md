# Gerakan dan Animasi

Bab ini akan menjelaskan beberapa hal berikut:

1. Menggerakkan Objek
2. Mengatur Animasi _Sprite_
3. Mengubah _Sprite_ Objek _Player_ Berdasarkan Posisi _Mouse_

## Menggerakkan Objek
Buat _script_ C# baru (misal kita beri nama _MovementInput.cs_), kemudian buka _script_ yang sudah dibuat pada _text editor_ atau _IDE yang telah ter-_install_ di komputer Anda. Tambahkan kedua _variabel_ berikut di dalam _class MovementInput_

```C#
public float speed = 5f;
```

Seluruh _public variable_ yang Anda masukkan dalam semua jenis _class_ secara otomatis akan tampil di tampilan _Inspector_ objek _Unity_ dan variabel tersebut dapat diubah nilainya dan disimpan perubahannya secara otomatis pada _Edit Mode_.

Supaya kita mampu menggerakkan objek sesuai dengan input yang diberikan pada _keyboard, maka kita harus tahu tombol mana saja yang ditekan. _Unity_ telah memudahkan kita untuk melakukan hal tersebut melalui sebuah _interface_ pada _class Input_ yang mengurus segala hal yang berkaitan dengan perangkat input. Tak hanya itu, _Unity_ juga menentukan fungsi masing-masing dari setiap tombol pada perangkat input, dalam kasus ini, kita mampu mendapatkan informasi input yang berkaitan dengan gerakan objek menggunakan fungsi _Input.GetAxisRaw()_. Pada fungsi _Update()_, tambahkan kode berikut:

```C#
    void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(inputX, inputY, 0);

        transform.Translate(movement * speed * Time.deltaTime);
    }
```

Fungsi _GetAxisRaw_ membutuhkan sebuah parameter input berupa _keyword_ untuk mendapatkan jenis input apa yang ingin didapatkan. Daftar _Keyword_ dapat kita lihat pada konfigurasi input _Unity_ melalui _Edit > Project Settings > Input Manager_

![Konfigurasi _Input Manager_](/img/input-manager.PNG)

Fungsi _GetAxisRaw_ akan menghasilkan nilai antara -1, 0, dan 1 tergantung dari tombol yang ditekan; apabila tombol diatur sebagai _negative button_, nilai yang dihasilkan adalah -1. Sebaliknya, apabila diatur sebagai _positive button_, nilai yang dihasilkan adalah 1. Apabila tidak ada tombol yang ditekan, nilai yang dihasilkan adalah 0.

Variable _inputX_ dan _inputY_ digunakan untuk menampung informasi input dari fungsi _Input.GetAxisRaw()_. Informasi input dari kedua variabel akan digabung menjadi satu variabel bertipe _Vector3_, yaitu sebuah _class_ yang mendefinisikan sebuah vektor dalam dimensi tiga. Objek akan digeser melalui fungsi _Translate()_ dengan variabel _Vector3_ sebagai input dan besar perpindahan objek. Terlihat pada contoh bahwa _movement_ selain dikalikan dengan _speed_ juga dikalikan dengan _Time.deltaTime_. Hal ini dilakukan agar simulasi perpindahan objek per detik dapat berjalan dengan benar, sebaliknya perpindahan objek akan terlihat semakin cepat.

Mari kita uji coba program yang telah kita tulis dengan menjalankan mode _Game mode_. Anda akan mendapati pergerakan diagonal objek yang terlihat lebih cepat dibanding pergerakan vertikal maupun horizontal. Hal ini terjadi karena perbedaan panjang vektor pada variabel _movement_. Untuk mengatasi masalah tersebut, kita perlu menormalisasi variabel _movement_ agar panjang vektornya bernilai 1.

<!--Tambahin gambar masalah normalisasi vektor-->

```C#
    void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");

        //Mengambil nilai variabel vektor unit dari variabel Vector3 yang baru dibuat
        Vector3 movement = new Vector3(inputX, inputY, 0).normalized;
```

## Mengatur Animasi _Sprite_
_Unity_ menyediakan dua _interface_ untuk mengatur animasi; _Animation_ dan _Animator Controller_. _Animation_ adalah objek yang menyimpan tindakan apa saja yang harus dilakukan selama satu animasi berjalan, sedangkan _Animator Controller_ adalah objek yang mengatur alur berjalannya kumpulan _Animation_. Kali ini kita akan mencoba mengubah _sprite_ (gambar yang ditampilkan untuk sebuah objek) melalui kedua _interface_ tersebut.

Pertama, kita atur _spritesheet_ yang berada pada folder _2-Gerakan-dan-Animasi > Sprites > Drone >_ untuk membagi kumpulan gambar pada _spritesheet_ menjadi gambar-gambar individu. Pilih gambar _player256.png_, kemudian perhatikan panel _Inspector_. Atur _spritesheet_ sesuai dengan pengaturan pada gambar berikut. Setelah itu, pilih "_Sprite Editor_".

![Konfigurasi _Sprites_](/img/config-sprites.PNG)

Pada _Sprite Editor_, pilih menu _Slice_, kemudian pada opsi _Type_, pilih _Grid By Cell Count_. Isikan kotak _C_ saja dengan nilai 8. Tekan _Slice_ dan simpan perubahan dengan menekan tombol _Apply_. _Spritesheet_ yang telah kita atur siap dipakai untuk dimasukkan ke objek _Animation_.

![Membagi _Spritesheet_](/img/slice-spritesheet.png)
![_Spritesheet_ yang sudah terbagi](/img/sliced-spritesheet.PNG)

Untuk menambahkan potongan _spritesheet_ ke dalam _Animation_, kita perlu menambahkan _component Animator Controller_ terlebih dahulu ke objek _player_. _Component Animator Controller_ ini perlu sebuah objek _Animator Controller_ yang bisa kita buat pada panel _Project_ dengan meng-klik kanan _window Project_, kemudian pilih _Create > Animator Controller_. Kemudian kita buat objek _Animation_ dengan meng-klik kanan pada _window Project_, pilih _Create > Animation_. Untuk bab ini kita buat empat objek _Animation_ dengan nama _Up_, _Down_, _Right_, dan _Left_. _Double-click_ objek _Animator Controller_ yang baru saja dibuat, kemudian _drag_ semua objek _Animation_ yang telah dibuat ke _window Animator Controller_ yang telah muncul.

![Isi _Window Animator Controller](/img/animator-controller.PNG)

Buka _window Animation_ untuk mulai mengatur animasi _sprite_ dengan memilih menu _Window > Animation > Animation_. Dengan objek _player_ terpilih, akan muncul _drop down menu_ di bawah teks _Preview_ yang menampilkan seluruh _Animation_ yang berada di dalam _Animator Controller_ objek _player_. Kita coba atur _Animation_ bernama _Up_ terlebih dahulu. Untuk memberi gambar pada _Animation_, cukup pindahkan _sprite_ yang menunjukkan _player_ menghadap ke atas ke panel di mana tombol _Add Property_ berada. Secara otomatis potongan _sprite_ akan masuk ke _keyframe_ ke-0.

![Isi _Window Animation_](/img/animation.PNG)

Berpindah ke _window Animator Controller_, kita atur bagaimana transisi tiap animasi berjalan. Setiap kotak yang Anda lihat di _window Animator Controller_ disebut sebagai _state_, baik kotak bertuliskan _Any State_, _End_, _Start_, dan _Animation_ yang telah Anda masukkan. Di _Animator Controller_ kita mengatur bagaimana alur perpindahan _state_ berjalan. Karena animasi pergerakan _player_ dapat berubah tergantung arah perpindahan _player_ dan tidak peduli pada arah mana _player_ menghadap, kita hubungkan kotak _Any State_ ke-empat _Animation_ kita dengan meng-klik kanan kotak _Any State_, pilih _Make Transition_, kemudian pilih _Animation_ yang ingin dihubungkan.

Transisi animasi akan berjalan apabila beberapa kondisi terpenuhi. Pada _Animator Controller_ terdapat empat macam tipe parameter yang bisa kita gunakan untuk menyusun kondisi transisi animasi; _float_, _integer_, _bool_, dan _trigger_. Parameter-parameter yang dibutuhkan terdapat pada tab _parameters_. Kita buat paramater baru bertipe _integer_. Penjelasan mengenai penggunaan parameter akan diterangkan pada sub-bab berikutnya.

## Mengubah _Sprite_ Objek _Player_ Berdasarkan Posisi _Mouse_
