# Navigasi Scene

Pada Sub bab ini, kita akan belajar cara melakukan navigasi pada scene dan bagaimana membuat kebutuhan lainnya.

**Agar workshop pada hari-h berjalan dengan lancar, setiap peserta diharapkan sudah melakukan instalasi unity secara mandiri pada komputer masing masing**

## Pembuatan Scene

Kali ini kita membutuhkan tiga scene, yaitu scene Menu, scene Setting, dan scene Game. Scene Menu berguna sebagai awal mula game dimulai.
Scene Setting digunakan untuk mengatur kebutuhan resolusi, dan scene Game sebagai scene inti dari game yang akan dibuat. Cara membuatnya mudah yaitu:

- Klik kanan pada Project
- Create Scene
- Rename dengan yang diinginkan

### Menu Scene
Disini kita akan membuat Menu scene yang berisikan tiga button, yaitu Play, Setting, dan Exit. untuk membuat nya:

- Klik kanan di hierarchy, UI, lalu button. Pada Hierarchy akan muncul button dengan text sebagai bawaannya.

- Setelah kita membuat 3 button dan diganti text nya, lalu kita membuat background.

- klik kanan di hierarchy, UI,lalu Panel. Panel digunakan sebagai background. Anda dapat mengganti gambar pada sprite.

- Kemudian kita akan membuat script dimana button tersebut akan berfungsi. peserta membuat script "MainMenu.cs" dengan kode berikut.

```C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void SettingGame()
    {
        SceneManager.LoadScene("Setting");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
```

- Kemudian membuat sebuah empty gameobject untuk menampung seluruh button nya, kita rename dengan "MainMenu" dan berikan script "MainMenu.cs"
- Pada Button, kemudian kita cari onClick, lalu kita add, dan masukkan "MainMenu". Disitu kita dapat melihat fungsi yang kita buat. Masukkan SettingGame() pada button setting dan seterusnya
- Kemudian menambahkan scene pada build, kita tambahkan ketiganya.
- Scene Menu dapat kita run

### Setting Scene

Disini kita akan membuat Setting scene yang berisikan Text untuk Title, Toggle, dan Dropdown. untuk membuat nya:

- Klik kanan di hierarchy, UI, lalu Text. Pada Hierarchy akan muncul text sebagai Judul.

- Setelah kita membuat Toggle dan diganti text nya.

- klik kanan di hierarchy, UI,lalu Dropdownl. Dropdown ini berfungsi sebagai tombol yang memiliki banyak opsi.

- Kemudian kita akan membuat script dimana button tersebut akan berfungsi. peserta membuat script "SettingMenu.cs" dengan kode berikut.

```C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingMenu : MonoBehaviour
{
    Resolution[] resolutions;
    public Dropdown resolutionDropdown;
    int currentResolutionIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        resolutions = Screen.resolutions;
        resolutionDropdown.ClearOptions();
        List<string> options = new List<string>();
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }
        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();

    }

    public void SetFullscreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
```

- Kemudian membuat sebuah empty gameobject untuk menampung seluruh text, toggle, dan dropdown nya, kita rename dengan "SettingMenu" dan berikan script "SettingMenu.cs", kemudian masukkan object dropdown pada script tersebut.
- Pada toggle, kemudian kita cari onClick, lalu kita add, dan masukkan "SettingMenu". Disitu kita dapat melihat fungsi yang kita buat. Masukkan SetFullscreen() pada button setting dan seterusnya
- Setting Menu dapat kita run

### Game Scene

TBA

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