#### SINIF
***
- [X] DurumEnum (enum)
    - ToDo
    - Doing
    - Done
- [X] Kategori (class)
    - Id, Guid
    - Ad, string
    - Renk, Color
- [X] Not class (class)
    - Id, Guid
    - Aciklama, string
    - OlusturulmaZamani, DateTime
    - DurumEnum, DurumEnum
    - Kategori, Kategori
- [X] KanbanProje (class)
    - Id, Guid
    - Ad, string
    - OlusturulmaZamani, DateTime
    - Notlar, List < Not >
- [X] KanbanVeri, (class)
    - Projeler, List < Proje >
    - Kategoriler, List < Kategori > 
#### TASARIM
***
- [X] AnaForm Tasarýmý
 
    ![](./KanbanOrnekTasarim\AnaForm.png)

- [X] ProjeEkleForm Tasarýmý

    ![](./KanbanOrnekTasarim\ProjeEkleForm.png)

- [X] KategoriEkleForm Tasarýmý

    ![](./KanbanOrnekTasarim\KategoriEkleForm.png)

- [X] ProjeForm Tasarýmý

    ![](./KanbanOrnekTasarim\ProjeForm.png)

- [X] NotEkleForm Tasarýmý

    ![](./KanbanOrnekTasarim\NotEkleForm.png)

- [X] OnIzlemeForm

    ![](./KanbanOrnekTasarim\OnIzlemeForm.png)

### ADIM ADIM

##### KategoriForm
- [X] AnaForm üzerinden 'Kategori Ekle' týklanýldýðý zaman KategoriEkleForm açýlmasý.
- [X] KategoriEkleForm üzerinde PictureBox'a týklanýldýðýnda ColorDialog tetiklenmesi.
- [X] ColorDialog'tan seçilen rengin PictureBox üzerinde gösterilmesi.
- [X] KategoriEkleForm üzerinden kategori eklenildiði zaman KategoriForm üzerindeki listede görüntüle.
- [X] AnaForm kapanýrken, kategori listesinin kaydedilmesi.

##### ProjeEkleForm
- [X] AnaForm üzerinden 'Proje Ekle' týklandýðý zaman ProjeEkleForm açýlmasý.
- [X] ProjeEkleForm üzerinden 'Ekle' butonuna týklanýldýðý zaman Projenin Kaydedilmesi.
 
##### AnaForm
- [X] AnaForm'da Projelere týklandýðý zaman kayýtlý projelerin açýlmasý. (MdiLayout TileVertical)

##### NotEkleForm
- [X] Kategoriler listesinden kayýtlý kategorilerin combobox'ta listelenmesi.
- [X] Seçili Kategorinin Ön izlemede renginin ve kategori adýnýn aktarýlmasý.
- [X] Açýklama max 140 karakter ayarlanmasý.
- [X] Açýklama yazýldýðýnda ön izlemede gösterilmesi. (anlýk)
- [X] Oluþturulan notun tarih ve saatinin ön izlemede gösterilmesi.

##### ProjeForm
- [X] ProjeForm üzerinden (ToDo, Doing, Done) panelerinin pencere büyüklüðüne göre ayarý. (TableLayoutPanel kullanýldý)
- [X] ProjeForm üzerinden Proje Sil týklanýldýðý zaman kayýtlý verilerden projenin silinmesi.
- [X] ProjeForm'da Not Ekle týklanýldýðý zaman NotEkleForm'un açýlmasý.
- [X] Ekle butonuna týlanýldýðý zaman ön izlemede bulunan notun görsel olarak ilgili projenin ToDo paneline aktarýlmasý. Ön izleme tasarýmýnda ihtiyaç duyulan nesneler public yapýlarak kullanýldý.
- [X] Doing Enumýna kayýtlý olan notlarýn Doing panelinde gösterilmesi.
- [X] Done Enumýna kayýtlý olan notlarýn Done panelinde gösterilmesi.
- [X] ToDo, Doing, Done panelleri arasýnda notlarýn sürükle býrak methodu ile taþýnmasý.
- [X] ProjeForm üzerinden paneller arasý not kopyalama iþlemi.


