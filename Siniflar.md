#### SINIF
***
- [X] DurumEnum (enum)
    - Todo (Yapilacaklar)
    - Doing (Yapýlýyor)
    - Done (Tamamlananlar)
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

### ADIM ADIM

##### KategoriForm
- [X] AnaForm üzerinden 'Kategori Ekle' týklanýldýðý zaman KategoriEkleForm açýlmasý.
- [X] KategoriEkleForm üzerinde PictureBox'a týklanýldýðýnda ColorDialog tetiklenmesi.
- [X] ColorDialog'tan seçilen rengin PictureBox üzerinde gösterilmesi.
- [X] KategoriEkleForm üzerinden kategori eklenildiði zaman KategoriForm üzerindeki listede görüntüle.
- [X] AnaForm kapanýrken, kategori listesinin kaydedilmesi.

##### ProjeEkleForm
- [X] AnaForm üzerinden 'Proje Ekle' týklandýðý zaman ProjeEkleForm açýlmasý.
- [X] ProjeEkleForm üzerinden 'Ekle' butonuna týklanýldýðý zaman ProjeForm açýlmasý (mdi)

##### ProjeForm
- [ ] Panellerde ToDo, Doing, Done yazýlarýnýn DurumEnum üzerinden aktarýlmasý.
- [ ] ProjeForm üzerinden (ToDo, Doing, Done) panelerinin pencere büyüklüðüne göre ayarý.

