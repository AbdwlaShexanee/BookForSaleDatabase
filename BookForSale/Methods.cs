using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.IO;
using System.Drawing;
namespace BookForSale
{
    class Methods
    {
      public  string id;
      public string title;
      public string namecreated;
      public string yearscreated;
      public string language;
      public string pageNumber;
      public string cost;
      public byte[] image;
      public string url;


        public byte[] filetobyte(string sPath)
        {
            byte[] data = null;
            FileInfo finfo = new FileInfo(sPath);
            long numBytes = finfo.Length;
            FileStream fstream = new FileStream(sPath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            data = br.ReadBytes((int)numBytes);
            br.Close();
            fstream.Close();
            return data;
        }

        // convert byte to image
        public MemoryStream byteToimage(byte[] image)
        {
            Bitmap bmp;
            var ms = new MemoryStream(image);
            bmp = new Bitmap(ms);
            return ms;
        }

        // Connection To Mysql Database
        private MySqlConnection con = new MySqlConnection("datasource=localhost;database=bookforsale;port=3306;username=root;password=");

        char[]text={'A','B','W','Z','K','L','1','3','6','4','D','N','F','G','J','I','R','E'};
        public string createrandomtext()
        {
            Random r=new Random();
            ;
            string random="";
            for(int a=0;a<8;a++){
                random+=text[r.Next(0,18)];
            }
            return random;
        }




        // Login Panel

        //login User
        public bool login(string username, string password)
        {
            bool marj=false;
            con.Open();
            MySqlCommand sql = new MySqlCommand("Select * from users where username=@user and password=@password", con);
            sql.Parameters.AddWithValue("@user", username);
            sql.Parameters.AddWithValue("@password", password);
            MySqlDataAdapter da = new MySqlDataAdapter(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            if (dt.Rows.Count > 0)
            {
                marj = true;
            }

            return marj;
        }

        //get Power User
        public int getPower(string username)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("Select * from users where username=@user", con);
            cmd.Parameters.AddWithValue("@user", username);
            MySqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            int power = int.Parse(dr["Power"].ToString());
            dr.Close();
            con.Close();
            return power;
        }

        // if Not User Created
        public int checkUser(string username)
        {
            int marj = 0;
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from users where username=@user",con);
            cmd.Parameters.AddWithValue("@user", username);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            if (dt.Rows.Count ==0)
            {
                marj = 1;
            }
            else
            {
                marj = 0;
            }
            return marj;
        }


        // Register Panel  method

        // register User
        public void register(string username,string password,string profilename,string phoneNumber){
            con.Open();
            MySqlCommand sql = new MySqlCommand("insert into users(username,password,profile_name,phone_number,recovery_code)values(@user,@pass,@profile,@phone,@code)", con);
            sql.Parameters.AddWithValue("@user", username);
            sql.Parameters.AddWithValue("@pass", password);
            sql.Parameters.AddWithValue("@profile", profilename);
            sql.Parameters.AddWithValue("@phone", phoneNumber);
            sql.Parameters.AddWithValue("@code", createrandomtext());
            sql.ExecuteNonQuery();
            con.Close();

         }

        // getCode panel Method

        //update Recovey Code
        public void updateRecoveryCode(string username)
        {
            con.Open();
            MySqlCommand sql = new MySqlCommand("update users set recovery_code=@code where username=@user ", con);
            sql.Parameters.AddWithValue("@user", username);
            sql.Parameters.AddWithValue("@code", createrandomtext());
            sql.ExecuteNonQuery();
            con.Close();
        }

        //Get Recovery Code
        public string getrecoveryCode(string username)
        {
            string code = "";
            con.Open();
            MySqlCommand sql = new MySqlCommand("Select * from users where username=@user", con);
            sql.Parameters.AddWithValue("@user", username);
            MySqlDataReader dr = sql.ExecuteReader();
            dr.Read();
            code = dr["recovery_code"].ToString();
            con.Close();
            dr.Close();
            return code;
        }

        // change Password Panel
        public void changePassword(string password ,string Username)
        {
            con.Open();
            MySqlCommand sql = new MySqlCommand("update users set password=@pass where username=@user",con);
            sql.Parameters.AddWithValue("@pass", password);
            sql.Parameters.AddWithValue("@user", Username);
            sql.ExecuteNonQuery();
            con.Close();
        }

        //GetPassword User
        public string getpasswordUser(string Username)
        {
            string password;
            con.Open();
            MySqlCommand sql = new MySqlCommand("Select * from Users where username=@user", con);
            sql.Parameters.AddWithValue("@user", Username);
            MySqlDataReader dr = sql.ExecuteReader();
            dr.Read();
            password = dr["Password"].ToString();
            con.Close();
            dr.Close();
            return password;
        }


        //Kurdish English Arabic Form

        // show All Book
        public DataTable showAllBookByLanguage(string language)
        {
            con.Open();
            MySqlCommand sql = new MySqlCommand("select id,title,name_created,years_created,Language,Page_number as PageNumber,Cost,Image_Book from book where language=@lang", con);
            sql.Parameters.AddWithValue("@lang", language);
            MySqlDataAdapter da = new MySqlDataAdapter(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        // Add Favarite Book
        public void AddFavariteBook(string username,string title, string name_created,string yearsCreated, string Language, string Page_Number, string Cost, byte[] Image_Book)
        {
            con.Open();
            MySqlCommand sql = new MySqlCommand("insert into favarite (username,title,name_created,years_created,Language,Page_Number,Cost,Image_Book)values(@user,@title,@name,@year,@lang,@page,@cost,@image)", con);
            sql.Parameters.AddWithValue("@user", username);
            sql.Parameters.AddWithValue("@title", title);
            sql.Parameters.AddWithValue("@name", name_created);
            sql.Parameters.AddWithValue("@year", yearsCreated);
            sql.Parameters.AddWithValue("@lang", Language);
            sql.Parameters.AddWithValue("@page", Page_Number);
            sql.Parameters.AddWithValue("@cost", Cost);
            sql.Parameters.AddWithValue("@image", Image_Book);
            sql.ExecuteNonQuery();
            con.Close();
        }

        //alredy added to favorite
        public int alredyaddedToFavorite(string username, string title, string name_created, string Language)
        {
            int num = 0;
            con.Open();
            MySqlCommand sql = new MySqlCommand("select * from favarite where username=@user and title=@title and name_created=@name and language=@lang", con);
            sql.Parameters.AddWithValue("@user",username);
            sql.Parameters.AddWithValue("@title",title);
            sql.Parameters.AddWithValue("@name",name_created);
            sql.Parameters.AddWithValue("@lang",Language);
            MySqlDataAdapter da = new MySqlDataAdapter(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                num = 1;
            }
            con.Close();
            return num;
        }

        //search Book 
        public DataTable searchBook(string Language, string text)
        {
            con.Open();
            MySqlCommand sql = new MySqlCommand("select id,title,name_created,years_created,Language,Page_number as PageNumber,Cost,Image_Book from book where title like '%" + text + "%' or name_created like '%" + text + "%' and language=@lang", con);
            sql.Parameters.AddWithValue("@lang", Language);
            MySqlDataAdapter da = new MySqlDataAdapter(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        //get Coin User
        public int getCoinUser(string username){
            con.Open();
            int coins ;
            MySqlCommand sql=new MySqlCommand("Select * from users where username=@user",con);
            sql.Parameters.AddWithValue("@user",username);
            MySqlDataReader dr=sql.ExecuteReader();
            dr.Read();
            coins=int.Parse(dr["coin"].ToString());
            con.Close();
            dr.Close();
            return coins;
        }

        //get profile Name User
        public string getprofileName(string username)
        {
            string profilename = "";
            con.Open();
            MySqlCommand sql = new MySqlCommand("Select * from users where username=@user", con);
            sql.Parameters.AddWithValue("@user", username);
            MySqlDataReader dr = sql.ExecuteReader();
            dr.Read();
            profilename = dr["profile_name"].ToString();
            con.Close();
            dr.Close();
            return profilename;
        }

        // update Coin User
        public void updatecoin(string username,string coin){
            con.Open();
            MySqlCommand sql = new MySqlCommand("update users set coin=@coins where username=@user", con);
            sql.Parameters.AddWithValue("@coins", coin);
            sql.Parameters.AddWithValue("@user", username);
            sql.ExecuteNonQuery();
            con.Close();
        }

        //get Url Book
        public string GetUrl(string title,string name_created ,string cost)
        {
            con.Open();
            MySqlCommand sql = new MySqlCommand("Select * from Book where title=@title and Name_Created=@name and Cost=@cost",con);
            sql.Parameters.AddWithValue("@title", title);
            sql.Parameters.AddWithValue("@name", name_created);
            sql.Parameters.AddWithValue("@cost", cost);
            MySqlDataReader dr = sql.ExecuteReader();
            dr.Read();
            string Url;
            Url= dr["Url_Book"].ToString();
            dr.Close();
            con.Close();
            return Url;
        }

        //Buy Book
        public void buyBook(string username,string title,string name_created,string years_created,string Language,string page_number,string cost,byte[] image_Book,string url_book)
        {
            con.Open();
            MySqlCommand sql = new MySqlCommand("insert into Download (Username,title,name_created,years_created,language,page_number,cost,image_Book,url_book)values(@Username,@title,@name,@years,@lang,@page,@cost,@image,@url)", con);
            sql.Parameters.AddWithValue("@Username", username);
            sql.Parameters.AddWithValue("@title",title);
            sql.Parameters.AddWithValue("@name",name_created);
            sql.Parameters.AddWithValue("@years",years_created);
            sql.Parameters.AddWithValue("@lang",Language);
            sql.Parameters.AddWithValue("@page",page_number);
            sql.Parameters.AddWithValue("@cost",cost);
            sql.Parameters.AddWithValue("@image",image_Book);
            sql.Parameters.AddWithValue("@url",url_book);
            sql.ExecuteNonQuery();
            con.Close();
        }

        //Check Alredy Buy Book
        public DataTable alredyBuyBook(string Username, string title, string Name_created, string Cost)
        {
            con.Open();
            MySqlCommand sql = new MySqlCommand("select * from Download where username=@user and title=@title and name_created=@name and cost=@cost", con);
            sql.Parameters.AddWithValue("@user",Username);
            sql.Parameters.AddWithValue("@title",@title);
            sql.Parameters.AddWithValue("@name",Name_created);
            sql.Parameters.AddWithValue("@cost",Cost);
            MySqlDataAdapter da = new MySqlDataAdapter(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        // Form Add Book 
        
        //Add new Book
        public void AddBook(string username, string title, string name_created, string years_created, string Language, string page_number, string cost, byte[] image_Book, string url_book)
        {
            con.Open();
            MySqlCommand sql = new MySqlCommand("insert into Book (Username,title,name_created,years_created,language,page_number,cost,image_Book,url_book)values(@Username,@title,@name,@years,@lang,@page,@cost,@image,@url)", con);
            sql.Parameters.AddWithValue("@Username", username);
            sql.Parameters.AddWithValue("@title", title);
            sql.Parameters.AddWithValue("@name", name_created);
            sql.Parameters.AddWithValue("@years", years_created);
            sql.Parameters.AddWithValue("@lang", Language);
            sql.Parameters.AddWithValue("@page", page_number);
            sql.Parameters.AddWithValue("@cost", cost);
            sql.Parameters.AddWithValue("@image", image_Book);
            sql.Parameters.AddWithValue("@url", url_book);
            sql.ExecuteNonQuery();
            con.Close();
        }
        

        // Form Edit Profile

        //Change Profile Name
        public void ChangeProfileName(string Username, string ProfileName)
        {
            con.Open();
            MySqlCommand sql = new MySqlCommand("update Users set profile_name=@profile where username=@user", con);
            sql.Parameters.AddWithValue("@profile", ProfileName);
            sql.Parameters.AddWithValue("@user", Username);
            sql.ExecuteNonQuery();
            con.Close();
        }

        // change Password 
        public void ChangePassword(string Username, string Password)
        {
            con.Open();
            MySqlCommand sql = new MySqlCommand("update Users set password=@pass where username=@user", con);
            sql.Parameters.AddWithValue("@pass", Password);
            sql.Parameters.AddWithValue("@user", Username);
            sql.ExecuteNonQuery();
            con.Close();
        }

        // Cart 12500

        // Show Cart 12500
        public DataTable showCart12500()
        {
            con.Open();
            MySqlCommand sql = new MySqlCommand("select id,cartNumber from cart12500 where sended=0", con);
            MySqlDataAdapter da = new MySqlDataAdapter(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        //Sended Cart Number 12500
        public void sendedCart12500(string cart)
        {
            con.Open();
            MySqlCommand sql = new MySqlCommand("updatecart12500 set sended=1 where cartNumber=@cart");
            sql.Parameters.AddWithValue("@cart", cart);
            sql.ExecuteNonQuery();
            con.Close();
        }

        // cart 5000
        
        // Show Cart 5000
        public DataTable showCart5000()
        {
            con.Open();
            MySqlCommand sql = new MySqlCommand("select id,cartNumber from cart5000 where sended=0", con);
            MySqlDataAdapter da = new MySqlDataAdapter(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        //Sended Cart Number 5000
        public void sendedCart5000(string cart)
        {
            con.Open();
            MySqlCommand sql = new MySqlCommand("updatecart12500 set sended=1 where cartNumber=@cart");
            sql.Parameters.AddWithValue("@cart", cart);
            sql.ExecuteNonQuery();
            con.Close();
        }


        //Charge Form

        //Select Type Cart 
        public int typeCart(string cart)
        {
            int type = 0;
            con.Open();
            MySqlCommand sql = new MySqlCommand("Select * from cart5000 where cartNumber=@cart", con);
            sql.Parameters.AddWithValue("@cart", cart);
            MySqlDataAdapter da = new MySqlDataAdapter(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                type = 1;
            }

            MySqlCommand sqll = new MySqlCommand("Select * from cart12500 where cartNumber=@cart", con);
            sqll.Parameters.AddWithValue("@cart", cart);
            MySqlDataAdapter daa = new MySqlDataAdapter(sqll);
            DataTable dtt = new DataTable();
            daa.Fill(dtt);
            if (dtt.Rows.Count > 0)
            {
                type = 2;
            }

            con.Close();
            return type;
        }

        //Charge Coin
        public void ChargeCoinUser(string Username, int coin)
        {
            con.Open();
            MySqlCommand sql = new MySqlCommand("update users set coin=@coin where username=@user", con);
            sql.Parameters.AddWithValue("@coin", coin);
            sql.Parameters.AddWithValue("@user", Username);
            sql.ExecuteNonQuery();
            con.Close();
        }

        // delete Cart12500
        public void deleteCart12500(string CartNumber)
        {
            con.Open();
            MySqlCommand sql = new MySqlCommand("Delete From cart12500 where cartNumber=@cart", con);
            sql.Parameters.AddWithValue("@cart", CartNumber);
            sql.ExecuteNonQuery();
            con.Close();
        }

        // delete Cart 5000
        public void deleteCart5000(string CartNumber)
        {
            con.Open();
            MySqlCommand sql = new MySqlCommand("Delete From cart5000 where cartNumber=@cart", con);
            sql.Parameters.AddWithValue("@cart", CartNumber);
            sql.ExecuteNonQuery();
            con.Close();
        }


        //Form Change Power

        //Change Power
        public void changepowerUser(string Username,int power)
        {
            con.Open();
            MySqlCommand sql = new MySqlCommand("update users set power=@power where username=@user",con);
            sql.Parameters.AddWithValue("@power", power);
            sql.Parameters.AddWithValue("@user", Username);
            sql.ExecuteNonQuery();
            con.Close();
        }

        
        //Form Delete Book

        //Show All Book User Uploaded
        public DataTable showallBookUser(string Username)
        {
            con.Open();
            MySqlCommand sql = new MySqlCommand("select * from book where Username=@user",con);
            sql.Parameters.AddWithValue("@user", Username);
            MySqlDataAdapter da = new MySqlDataAdapter(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        //Show All Book User
        public DataTable showallBook()
        {
            con.Open();
            MySqlCommand sql = new MySqlCommand("select * from book", con);
            MySqlDataAdapter da = new MySqlDataAdapter(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        //delete Book by id
        public void deleteBook(int id)
        {
            con.Open();
            MySqlCommand sql = new MySqlCommand("delete from book where id=@id",con);
            sql.Parameters.AddWithValue("@id", id);
            sql.ExecuteNonQuery();
            con.Close();
        }


        //Form All Message

        //show All Message
        public DataTable showAllMessage()
        {
            con.Open();
            MySqlCommand sql = new MySqlCommand("Select * from allmessage", con);
            MySqlDataAdapter da = new MySqlDataAdapter(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        //delete Message
        public void deleteMessage(int id)
        {
            con.Open();
            MySqlCommand sql = new MySqlCommand("DELETE FROM `allmessage` WHERE `id`=@id", con);
            sql.Parameters.AddWithValue("@id", id);
            sql.ExecuteNonQuery();
            con.Close();
        }
        

        //Form Favorite

        //Show All Favorite
        public DataTable showallFavorite(string User)
        {
            con.Open();
            MySqlCommand sql = new MySqlCommand("Select id,title,name_created,years_created,language,page_number,cost,image_book from favarite where username=@user", con);
            sql.Parameters.AddWithValue("@user", User);
            MySqlDataAdapter da = new MySqlDataAdapter(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        //Search Favorite Book
        public DataTable SearchFavorite(string User, string text)
        {
            con.Open();
            MySqlCommand sql = new MySqlCommand("SELECT id,title,name_created,years_created,language,page_number,cost,image_book FROM `favarite` WHERE `Username`=@user AND `title` LIKE '%"+text+"%'", con);
            sql.Parameters.AddWithValue("@user", User);
            MySqlDataAdapter da = new MySqlDataAdapter(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        // UnFavorite Book
        public void UnFavorite(string id)
        {
            con.Open();
            MySqlCommand sql = new MySqlCommand("delete from favarite where `id`=@id", con);
            sql.Parameters.AddWithValue("@id", id);
            sql.ExecuteNonQuery();
            con.Close();
        }

        //Download Book Form

        //Show All Download Book
        public DataTable showallDownload(string Username)
        {
            con.Open();
            MySqlCommand sql = new MySqlCommand("Select id,title,name_created,years_created,language,page_number,cost,image_book from Download where username=@user", con);
            sql.Parameters.AddWithValue("@user", Username);
            MySqlDataAdapter da = new MySqlDataAdapter(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        //Search Download Book
        public DataTable SearchDownload(string text,string Username)
        {
            con.Open();
            MySqlCommand sql = new MySqlCommand("select id,title,name_created,years_created,language,page_number,cost,image_book from Download where username=@user and title like '%" + text + "%'", con);
            sql.Parameters.AddWithValue("@user", Username);
            sql.Parameters.AddWithValue("@use", Username);
            MySqlDataAdapter da = new MySqlDataAdapter(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        // Form Send Message
        public void sendMessage(string username, string title, string msg)
        {
            con.Open();
            MySqlCommand sql = new MySqlCommand("insert into allmessage (username,title,message) values(@user,@title,@msg)", con);
            sql.Parameters.AddWithValue("@user", username);
            sql.Parameters.AddWithValue("@title", title);
            sql.Parameters.AddWithValue("@msg", msg);
            sql.ExecuteNonQuery();
            con.Close();
        }

    }
}
