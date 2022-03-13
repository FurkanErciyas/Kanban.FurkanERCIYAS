#### SINIF
***
- [X] DurumEnum (enum)
    - Todo (Yapilacaklar)
    - Doing (Yap�l�yor)
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
- [X] AnaForm Tasar�m�
 
    ![](./KanbanOrnekTasarim\AnaForm.png)

- [X] ProjeEkleForm Tasar�m�

    ![](./KanbanOrnekTasarim\ProjeEkleForm.png)

- [X] KategoriEkleForm Tasar�m�

    ![](./KanbanOrnekTasarim\KategoriEkleForm.png)

- [X] ProjeForm Tasar�m�

    ![](./KanbanOrnekTasarim\ProjeForm.png)

- [X] NotEkleForm Tasar�m�

    ![](./KanbanOrnekTasarim\NotEkleForm.png)

### ADIM ADIM

##### KategoriForm
- [X] AnaForm �zerinden 'Kategori Ekle' t�klan�ld��� zaman KategoriEkleForm a��lmas�.
- [X] KategoriEkleForm �zerinde PictureBox'a t�klan�ld���nda ColorDialog tetiklenmesi.
- [X] ColorDialog'tan se�ilen rengin PictureBox �zerinde g�sterilmesi.
- [X] KategoriEkleForm �zerinden kategori eklenildi�i zaman KategoriForm �zerindeki listede g�r�nt�le.
- [X] AnaForm kapan�rken, kategori listesinin kaydedilmesi.

##### ProjeEkleForm
- [X] AnaForm �zerinden 'Proje Ekle' t�kland��� zaman ProjeEkleForm a��lmas�.
- [X] ProjeEkleForm �zerinden 'Ekle' butonuna t�klan�ld��� zaman ProjeForm a��lmas� (mdi)

##### ProjeForm
- [ ] Panellerde ToDo, Doing, Done yaz�lar�n�n DurumEnum �zerinden aktar�lmas�.
- [ ] ProjeForm �zerinden (ToDo, Doing, Done) panelerinin pencere b�y�kl���ne g�re ayar�.

