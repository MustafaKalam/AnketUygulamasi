using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FiyatListesiAdoNET.DataAccess.Concreate
{
    public class FiyatListesiDal
    {
        static string _connectionString = @"server=db.acilimsoft.com\SQL2014; initial catalog=DEMOENDER19; user id=sa; Password=Admin@D3VSRV2;";
        //static string _connectionString = @"server=ACILIMSOFT\SQLEXPRESS; initial catalog=SENGUL; integrated security=True";
        SqlConnection _connection = new SqlConnection(_connectionString);

        public List<Malzemeler> DetayListeGetir()
        {
            ConnectionControl();

            //string query = "SELECT a.r_sayac, a.liste_kodu, a.liste_adi, ISNULL(a.pasif,0) AS pasif, a.baslangic_tarihi, a.bitis_tarihi, a.kategori_rsayac, a.cid FROM sts_fiyat_listesi a";
            string query1 = " SELECT b.r_sayac, b.fiyat_liste_rsayac, ISNULL(a.liste_adi,'') AS liste_adi, ISNULL(b.malzeme_kodu,'') AS malzeme_kodu, c.malzeme_adi, b.birim, ISNULL(b.indirim01_flag,0) AS indirim01_flag, ISNULL(b.indirim01,0) AS indirim01  ";
            string query2 = " FROM sts_fiyat_listesi a, sts_fiyat_listesi_satir b, mlz_tanimi c WHERE a.r_sayac=b.fiyat_liste_rsayac AND b.malzeme_kodu=c.malzeme_kodu AND ISNULL(b.malzeme_kodu,'')<>'' ";

            SqlCommand command = new SqlCommand(query1 + query2, _connection);
            SqlDataReader reader = command.ExecuteReader();

            List<Malzemeler> malzemelers = new List<Malzemeler>();
            while (reader.Read())
            {
                Malzemeler malzemeler = new Malzemeler
                {
                    r_sayac = Convert.ToInt32(reader["r_sayac"]),
                    fiyat_liste_rsayac = Convert.ToInt32(reader["fiyat_liste_rsayac"]),
                    liste_adi = reader["liste_adi"].ToString(),
                    malzeme_kodu = reader["malzeme_kodu"].ToString(),
                    malzeme_adi = reader["malzeme_adi"].ToString(),
                    birim = reader["birim"].ToString(),
                    indirim01_flag = Convert.ToInt32(reader["indirim01_flag"]),
                    indirim01 = Convert.ToInt32(reader["indirim01"])
                };
                malzemelers.Add(malzemeler);
            }
            reader.Close();
            _connection.Close();
            return malzemelers;
        }

        public List<Malzemeler> DetayListeGetirByMlzSinifi(string mlz_sinifi_no)
        {
            ConnectionControl();

            //string query = "SELECT a.r_sayac, a.liste_kodu, a.liste_adi, ISNULL(a.pasif,0) AS pasif, a.baslangic_tarihi, a.bitis_tarihi, a.kategori_rsayac, a.cid FROM sts_fiyat_listesi a";
            string query1 = " SELECT b.r_sayac, b.fiyat_liste_rsayac, ISNULL(a.liste_adi,'') AS liste_adi, ISNULL(b.malzeme_kodu,'') AS malzeme_kodu, c.malzeme_adi, b.birim, ISNULL(b.indirim01_flag,0) AS indirim01_flag, ISNULL(b.indirim01,0) AS indirim01  ";
            if (mlz_sinifi_no == "-1" || String.IsNullOrEmpty(mlz_sinifi_no))
            {
                query1 += " FROM sts_fiyat_listesi a, sts_fiyat_listesi_satir b, mlz_tanimi c WHERE a.r_sayac=b.fiyat_liste_rsayac AND b.malzeme_kodu=c.malzeme_kodu AND ISNULL(b.malzeme_kodu,'')<>'' ";
            }
            else
            {
                query1 += " FROM sts_fiyat_listesi a, sts_fiyat_listesi_satir b, mlz_tanimi c WHERE a.r_sayac=b.fiyat_liste_rsayac AND b.malzeme_kodu=c.malzeme_kodu AND ISNULL(b.malzeme_kodu,'')<>'' AND ISNULL(c.malzeme_sinifi_no,'')=@malzeme_sinifi_no ";
            }
            //string query2 = " FROM sts_fiyat_listesi a, sts_fiyat_listesi_satir b, mlz_tanimi c WHERE a.r_sayac=b.fiyat_liste_rsayac AND b.malzeme_kodu=c.malzeme_kodu AND ISNULL(b.malzeme_kodu,'')<>'' AND ISNULL(c.malzeme_sinifi_no,'')=@malzeme_sinifi_no ";
            string aa = query1;
            SqlCommand command = new SqlCommand(query1, _connection);
            if (mlz_sinifi_no != "-1" || String.IsNullOrEmpty(mlz_sinifi_no))
            {
                command.Parameters.AddWithValue("@malzeme_sinifi_no", mlz_sinifi_no);
            }

            SqlDataReader reader = command.ExecuteReader();

            List<Malzemeler> malzemelers = new List<Malzemeler>();
            while (reader.Read())
            {
                Malzemeler malzemeler = new Malzemeler
                {
                    r_sayac = Convert.ToInt32(reader["r_sayac"]),
                    fiyat_liste_rsayac = Convert.ToInt32(reader["fiyat_liste_rsayac"]),
                    liste_adi = reader["liste_adi"].ToString(),
                    malzeme_kodu = reader["malzeme_kodu"].ToString(),
                    malzeme_adi = reader["malzeme_adi"].ToString(),
                    birim = reader["birim"].ToString(),
                    indirim01_flag = Convert.ToInt32(reader["indirim01_flag"]),
                    indirim01 = Convert.ToInt32(reader["indirim01"])
                };
                malzemelers.Add(malzemeler);
            }
            reader.Close();
            _connection.Close();
            return malzemelers;
        }

        public void Insert(Malzemeler malzemeler)
        {
            ConnectionControl();

            string query = "INSERT INTO sts_fiyat_listesi_satir(fiyat_liste_rsayac, malzeme_kodu, indirim01_flag, indirim01, birim, cid) VALUES(@fiyat_liste_rsayac, @malzeme_kodu, @indirim01_flag, @indirim01, @birim, @cid)";
            SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@fiyat_liste_rsayac", malzemeler.fiyat_liste_rsayac);
            command.Parameters.AddWithValue("@malzeme_kodu", malzemeler.malzeme_kodu);
            command.Parameters.AddWithValue("@indirim01_flag", malzemeler.indirim01_flag);
            command.Parameters.AddWithValue("@indirim01", malzemeler.indirim01);
            command.Parameters.AddWithValue("@birim", malzemeler.birim);
            command.Parameters.AddWithValue("@cid", malzemeler.cid);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void Update(Malzemeler malzemeler)
        {
            ConnectionControl();
            string query = "UPDATE a SET a.fiyat_liste_rsayac=@fiyat_liste_rsayac, a.malzeme_kodu=@malzeme_kodu, a.indirim01_flag=@indirim01_flag, indirim01=@indirim01 FROM sts_fiyat_listesi_satir a WHERE a.r_sayac=@r_sayac";
            SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@r_sayac", malzemeler.r_sayac);
            command.Parameters.AddWithValue("@fiyat_liste_rsayac", malzemeler.fiyat_liste_rsayac);
            command.Parameters.AddWithValue("@malzeme_kodu", malzemeler.malzeme_kodu);
            command.Parameters.AddWithValue("@indirim01_flag", malzemeler.indirim01_flag);
            command.Parameters.AddWithValue("@indirim01", malzemeler.indirim01);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public List<MalzemeSinifi> MalzemeSinifiLoad()
        {
            ConnectionControl();
            string query = "SELECT a.r_sayac, a.malzeme_sinifi_id, ISNULL(a.malzeme_sinifi_adi,'') AS malzeme_sinifi_adi FROM mlz_siniflari_satir a  ORDER BY a.malzeme_sinifi_adi ASC";
            SqlCommand command = new SqlCommand(query, _connection);
            SqlDataReader reader = command.ExecuteReader();

            List<MalzemeSinifi> sinifs = new List<MalzemeSinifi>();
            MalzemeSinifi malzemeSinifi1 = new MalzemeSinifi
            {
                r_sayac = -1,
                malzeme_sinifi_id = "-1",
                malzeme_sinifi_adi = "Tümü"
            };
            sinifs.Add(malzemeSinifi1);
            while (reader.Read())
            {
                MalzemeSinifi malzemeSinifi = new MalzemeSinifi
                {
                    r_sayac = Convert.ToInt32(reader["r_sayac"]),
                    malzeme_sinifi_id = reader["malzeme_sinifi_id"].ToString(),
                    malzeme_sinifi_adi = reader["malzeme_sinifi_adi"].ToString()
                };
                sinifs.Add(malzemeSinifi);
            }
            reader.Close();
            _connection.Close();
            return sinifs;
        }

        public Malzemeler MalzemeKoduKontrol(string malzeme_kodu)
        {
            ConnectionControl();
            string query = "SELECT a.malzeme_adi, a.baz_birim FROM mlz_tanimi a WHERE a.malzeme_kodu=@malzeme_kodu ";
            SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@malzeme_kodu", malzeme_kodu);

            SqlDataReader reader = command.ExecuteReader();

            List<Malzemeler> mlzBilgi = new List<Malzemeler>();

            while (reader.Read())
            {
                Malzemeler malzemeler = new Malzemeler
                {
                    malzeme_adi = reader["malzeme_adi"].ToString(),
                    birim = reader["baz_birim"].ToString()
                };
                mlzBilgi.Add(malzemeler);
            }
            reader.Close();
            _connection.Close();

            return mlzBilgi.FirstOrDefault();
        }

        public List<FiyatListesi> FListesiDoldur()
        {
            ConnectionControl();
            string query = "SELECT a.r_sayac, a.liste_kodu, a.liste_adi FROM sts_fiyat_listesi a WHERE ISNULL(a.pasif,0)<>1 ";
            SqlCommand command = new SqlCommand(query, _connection);
            SqlDataReader reader = command.ExecuteReader();

            List<FiyatListesi> liste = new List<FiyatListesi>();
            while (reader.Read())
            {
                FiyatListesi fiyatListesi = new FiyatListesi
                {
                    r_sayac = Convert.ToInt32(reader["r_sayac"]),
                    liste_kodu = reader["liste_kodu"].ToString(),
                    liste_adi = reader["liste_adi"].ToString()
                };
                liste.Add(fiyatListesi);
            }
            reader.Close();
            _connection.Close();
            return liste;
        }
    }
}
