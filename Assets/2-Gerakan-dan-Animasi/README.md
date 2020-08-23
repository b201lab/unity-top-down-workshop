# Gerakan dan Animasi

Bab ini akan menjelaskan beberapa hal berikut:

1. Menggerakkan Objek
2. Mengambil Posisi _Mouse_
3. Mengatur Animasi _Sprite_
4. Mengubah _Sprite_ Objek _Player_ Berdasarkan Posisi _Mouse_

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

<!-- Tambahin gambar Project Settings > Input Manager -->

Fungsi _GetAxisRaw_ akan menghasilkan nilai antara -1, 0, dan 1 tergantung dari tombol yang ditekan; apabila tombol diatur sebagai _negative button_, nilai yang dihasilkan adalah -1. Sebaliknya, apabila diatur sebagai _positive button_, nilai yang dihasilkan adalah 1. Apabila tidak ada tombol yang ditekan, nilai yang dihasilkan adalah 0.

Variable _inputX_ dan _inputY_ digunakan untuk menampung informasi input dari fungsi _Input.GetAxisRaw()_. Informasi input dari kedua variabel akan digabung menjadi satu variabel bertipe _Vector3_, yaitu sebuah _class_ yang mendefinisikan sebuah vektor dalam dimensi tiga. Objek akan digeser melalui fungsi _Translate()_ dengan variabel _Vector3_ sebagai input dan besar perpindahan objek. Terlihat pada contoh bahwa _movement_ selain dikalikan dengan _speed_ juga dikalikan dengan _Time.deltaTime_. Hal ini dilakukan agar simulasi perpindahan objek per detik dapat berjalan dengan benar, sebaliknya perpindahan objek akan terlihat semakin cepat.

Mari kita uji coba program yang telah kita tulis dengan menjalankan mode _Game mode_. Anda akan mendapati pergerakan diagonal objek yang terlihat lebih cepat dibanding pergerakan vertikal maupun horizontal. Hal ini terjadi karena perbedaan panjang vektor pada variabel _movement_. Untuk mengatasi masalah tersebut, kita perlu menormalisasi variabel _movement_ agar panjang vektornya bernilai 1.

```C#
    void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");

        //Mengambil nilai variabel vektor unit dari variabel Vector3 yang baru dibuat
        Vector3 movement = new Vector3(inputX, inputY, 0).normalized;
```