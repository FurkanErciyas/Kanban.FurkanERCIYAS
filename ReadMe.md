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

- [X] OnIzlemeForm

    ![](./KanbanOrnekTasarim\OnIzlemeForm.png)

### ADIM ADIM

##### KategoriForm
- [X] AnaForm �zerinden 'Kategori Ekle' t�klan�ld��� zaman KategoriEkleForm a��lmas�.
- [X] KategoriEkleForm �zerinde PictureBox'a t�klan�ld���nda ColorDialog tetiklenmesi.
- [X] ColorDialog'tan se�ilen rengin PictureBox �zerinde g�sterilmesi.
- [X] KategoriEkleForm �zerinden kategori eklenildi�i zaman KategoriForm �zerindeki listede g�r�nt�le.
- [X] AnaForm kapan�rken, kategori listesinin kaydedilmesi.

##### ProjeEkleForm
- [X] AnaForm �zerinden 'Proje Ekle' t�kland��� zaman ProjeEkleForm a��lmas�.
- [X] ProjeEkleForm �zerinden 'Ekle' butonuna t�klan�ld��� zaman Projenin Kaydedilmesi.
 
##### AnaForm
- [X] AnaForm'da Projelere t�kland��� zaman kay�tl� projelerin a��lmas�. (MdiLayout TileVertical)

##### NotEkleForm
- [X] Kategoriler listesinden kay�tl� kategorilerin combobox'ta listelenmesi.
- [X] Se�ili Kategorinin �n izlemede renginin ve kategori ad�n�n aktar�lmas�.
- [X] A��klama max 140 karakter ayarlanmas�.
- [X] A��klama yaz�ld���nda �n izlemede g�sterilmesi. (anl�k)
- [X] Olu�turulan notun tarih ve saatinin �n izlemede g�sterilmesi.

##### ProjeForm
- [X] ProjeForm �zerinden (ToDo, Doing, Done) panelerinin pencere b�y�kl���ne g�re ayar�. (TableLayoutPanel kullan�ld�)
- [X] ProjeForm �zerinden Proje Sil t�klan�ld��� zaman kay�tl� verilerden projenin silinmesi.
- [X] ProjeForm'da Not Ekle t�klan�ld��� zaman NotEkleForm'un a��lmas�.
- [X] Ekle butonuna t�lan�ld��� zaman �n izlemede bulunan notun g�rsel olarak ilgili projenin ToDo paneline aktar�lmas�. �n izleme tasar�m�nda ihtiya� duyulan nesneler public yap�larak kullan�ld�.
- [X] Doing Enum�na kay�tl� olan notlar�n Doing panelinde g�sterilmesi.
- [X] Done Enum�na kay�tl� olan notlar�n Done panelinde g�sterilmesi.
- [X] ToDo, Doing, Done panelleri aras�nda notlar�n s�r�kle b�rak methodu ile ta��nmas�.
- [X] ProjeForm �zerinden paneller aras� not kopyalama i�lemi.


