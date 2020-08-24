# _Object Collision_

Topik yang dibahas pada bab ini yaitu:

1. _Object Spawning_ (_Instantiate_)
2. _Collider_
3. _Collision vs Trigger_
4. Menjalankan Perintah Saat Terjadi _Collision_

## _Object Spawning_ (_Instantiate_)
_Object spawning_ adalah proses memunculkan objek dalam permainan. _Unity_ menyebut proses ini sebagai _instantiate_.

Misal kita ingin memunculkan objek musuh pada permainan kita. Kita panggil sebuah fungsi bernama _Instantiate()_ untuk membuat objek baru. Objek yang dibuat nanti secara otomatis akan ditambahkan pada daftar _Hierarchy_. Fungsi ini dapat mengambil berbagai parameter untuk mengetahui bagaimana objek baru akan dibuat, seperti posisi, relasi dengan objek lain, rotasi objek, dan objek apa yang akan dibuat.

Kita buat objek baru bernama _GameController_ untuk mengurus proses _spawn_ musuh, kemudian buat _script_ baru dan pasang di objek _GameController_. Buka _text editor_ atau _IDE_ untuk membuka file _script_, kemudian tambahkan variabel berikut di dalam _class GameController_

```C#
//GameController.cs
    public GameObject enemy;
    public int spawnTime;
    private int timer=0;
```

Variabel _enemy_ menyimpan informasi mengenai objek yang akan dimunculkan. Pada tampilan _Inspector_, kotak _enemy_ dapat kita isi dengan sebuah objek _prefab_, yaitu sebuah objek pada _scene Unity_ yang telah tersimpan menjadi sebuah file.Untuk bab ini, kami telah menyediakan _prefab_ objek musuh pada direktori _/Assets/3-Object-Collision/Prefab_ dengan file bernama _Enemy_. Kita isi kotak _enemy_ dengan _prefab Enemy_.

![Prefab](/img/prefab.png)

Variabel _spawnTime_ menampung "waktu" yang dibutuhkan untuk meng-_spawn_ satu objek musuh, sedangkan _timer_ adalah waktu yang telah berjalan. Nilai _timer_ akan terus bertambah senilai 1 setiap fungsi _Update()_ berjalan dan apabila nilai _timer_ lebih dari nilai _spawnTime_, maka fungsi _Instantiate()_ akan berjalan untuk memunculkan objek musuh baru. Variabel _spawnTime_ pada awal permainan (fungsi _Start()_) dan saat nilai _timer_ lebih dari nilai _spawnTime_ akan diberi nilai acak dalam rentang tertentu.

```C#
//GameController.cs
    void Start()
    {
        player = GameObject.Find("Player");
        spawnTime = Random.Range(30, 180);
    }

    void Update()
    {
        timer++;
        if(timer >= spawnTime)
        {
            Instantiate(enemy, new Vector3(Random.Range(-7f, 7f), -5.9f, 0f), Quaternion.identity);
            
            spawnTime = Random.Range(30, 180);
            timer = 0;
        }
    }
```
Fungsi _Instantiate_ yang kita gunakan memerlukan tiga parameter; objek yang akan di-_spawn_, lokasi _spawn_, dan rotasi objek. Parameter pertama memerlukan variabel tipe _GameObject_, sehingga cukup masukkan variabel _enemy_ ke parameter pertama. Untuk parameter kedua, sesuaikan dengan kondisi _scene_ Anda. Kita coba untuk mengatur posisi _spawn_ berada di bawah area bermain dan di luar pandangan kamera.

![Spawn](/img/spawn.png)

Karena sistem rotasi _Unity_ menggunakan metode _Quaternion_ dan kita tidak menginginkan perubahan rotasi pada objek musuh, isikan _Quaternion.identity_ pada paramater ketiga.

Mari kita uji permainan dengan berpindah ke _Game mode_. Pada tampilan _Game view_, Anda tidak dapat melihat objek musuh yang telah di-_spawn_. Selain karena posisi objek di luar jangkauan kamera, objek musuh juga tidak bergerak sama sekali. Pada _prefab Enemy_, kami telah menyiapkan _script_ yang juga mengurus pergerakan musuh. Pergerakan musuh hanya membutuhkan informasi kecepatan bergerak.

Fungsi _Instantiate()_ selain digunakan untuk membuat objek baru juga digunakan untuk merujuk objek baru yang telah dibuat tadi. Kita hanya cukup membuat satu variabel _GameObject_ untuk menampung objek tersebut.

```C#
    GameObject spawnedObject = Instantiate(enemy, new Vector3(Random.Range(-7f, 7f), -5.9f, 0f), Quaternion.identity);
```
Setelah ini, kita mampu mengakses segala _component_ yang terpasang pada objek musuh dengan fungsi _GameObject.GetComponent<>()_. Pastikan nama tipe _component_ yang Anda masukkan dalam kurung siku sesuai dengan nama tipe _component_ yang telah terpasang pada objek musuh.

```C#
    GameObject spawnedEnemy = Instantiate(enemy, new Vector3(Random.Range(-7f, 7f), -5.9f, 0f), Quaternion.identity);
    spawnedEnemy.GetComponent<EnemyMovement>().enemySpeed = Random.Range(1f, 4f);
    spawnedEnemy.GetComponent<EnemyMovement>().hp = 2;
```

Berikut isi akhir program _GameController.cs_:
```C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameObject player;
    public GameObject enemy;
    public int spawnTime;
    private int timer=0;

    void Start()
    {
        player = GameObject.Find("Player");
        spawnTime = Random.Range(30, 180);
    }

    void Update()
    {
        timer++;
        if(timer >= spawnTime)
        {
            GameObject spawnedEnemy = Instantiate(enemy, new Vector3(Random.Range(-7f, 7f), -5.9f, 0f), Quaternion.identity);
            spawnedEnemy.GetComponent<EnemyMovement>().enemySpeed = Random.Range(1f, 4f);
            spawnedEnemy.GetComponent<EnemyMovement>().hp = 2;
            spawnTime = Random.Range(30, 180);
            timer = 0;
        }
    }
}
```

## _Collider_
_Collider_ adalah _component_ yang mendefinisikan daerah interaksi objek dengan objek lain. Sebagai catatan penting, besar dan bentuk _collider_ tidak perlu mengikuti bentuk dari tampilan objek, baik bentuk _sprite_ maupun bentuk model 3D objek. Berdasarkan jenis dimensi permainan yang kita terapkan, terdapat dua jenis _collider_; _Collider_ dan _Collider2D_. _Collider2D_ sendiri memiliki beberapa jenis _collider_ berdasarkan bentuknya; _BoxCollider2D_, _CapsuleCollider2D_, _CircleCollider2D_, _CompositeCollider2D_, _EdgeCollider2D_, dan _PolyCollider2D_. Pada pelatihan ini, kita cukup menggunakan _CircleCollider2D_ dan _BoxCollider2D_ yang merupakan _collider_ umum diterapkan pada permainan dan mudah diatur.

Sebelum menambah _collider_, pastikan _component RigidBody2D_ telah terpasang pada objek yang akan diberi _collider_. Hal ini disebabkan karena _collider_ perlu menerima hasil simulasi _physics_ dari _component RigidBody_.

![RigidBody2D-Collider2D](img/rb2-collider.png)

## _Collision vs Trigger_
_Collider_ mengeluarkan dua jenis output apabila terjadi interaksi dengan objek lain; _collision_ dan _trigger_. Perbedaan dari kedua output ini adalah _collision_ memberi hasil lebih rinci mengenai interaksi yang terjadi, mulai dari titik singgung dua _collider_, kecepatan objek lain saat interaksi terjadi, _collider_ dari objek lain, dan jumlah objek yang berinteraksi dengan _collider_ objek, sedangkan _trigger_ hanya memberi informasi tentang _collider_ objek lain. Karena _collider_ terhubung dengan _component GameObject_, kita juga mampu mengakses informasi objek yang terhubung dengan _collider_ tersebut.

## Menjalankan Perintah Saat Terjadi _Collision_
_Unity_ menyediakan _interface_ untuk menjalankan beberapa program saat _collision_ terjadi. Apabila kita menginginkan output berupa _collision_ dari _collider_, kita dapat menggunakan _interface_ berupa _OnCollisionEnter()_, _OnCollisionStay()_, dan _OnCollisionExit()_. _OnCollisionEnter()_ dipanggil ketika _collider_ baru saja menyentuh _collider_ lain, _OnCollisionExit()_ dipanggil ketika _collider_ berhenti menyentuh _collider_ lain, dan _OnCollisionStay()_ dipanggil selama _collider_ bersentuhan dengan _collider_ lain. Ketiga fungsi tersebut memiliki jenis parameter yang sama, yaitu _Collision_, untuk kita menggunakan informasi _collision_ pada program kita. Hal tersebut berlaku pula untuk output _trigger_; ketiga _interface_ yang dapat digunakan adalah _OnTriggerEnter()_, _OnTriggerExit()_, dan _OnTriggerStay()_. Jenis parameter yang digunakan untuk ketiga _interface_ tersebut adalah _Collider_. Semua jenis _interface_ akan dipanggil sesuai dengan kondisi yang terjadi pada permainan oleh _physics engine Unity_.

Sekarang mari kita coba menambahkan fitur baru; peluru pemain. Misalkan kita atur peluru untuk tidak melakukan interaksi apapun dengan objek yang memiliki _tag_ "_Player_". Apabila terjadi interaksi, maka hancurkan objek peluru tersebut. Kami telah menyediakan _prefab_ untuk peluru pemain bernama _PlayerBullet_ pada folder _/Assets/3-Object-Collision/Prefab_. Pilih _prefab_ tersebut, kemudian pada tampilan _Inspector_, buka _script BulletMovement.cs_.

Karena kita hanya ingin tau apakah peluru berinteraksi dengan objek lain tanpa perlu informasi lengkap mengenai interaksi yang terjadi dan program hanya berjalan saat peluru mulai bersentuhan dengan _collider_ lain, kita gunakan _interface OnTriggerEnter2D()_.

```C#
void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag!="Player")
        {
            Destroy(this.gameObject);
        }
    }
```