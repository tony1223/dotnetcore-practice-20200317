# dotnetcore-practice-20200317
A project for dotnetcore practice.

## steps

1. 安裝 dotnet core

2. 安裝 visual studio community verison , 安裝時要啟用 dotnet core 跟 web 相關的選項

3. 開啟 visual studio , create new solution (專案)

a. 選擇範本 asp.net core 
b. 專案名稱輸入 dotnetcore-practice
c. 位置自己選自己想要的位置
d. 按建立
e. 選 web應用程式(版本是 dotnet core 3.0)
f. 再按一次建立, 然後等待專案建立完畢.


4. 再來處理 database 的環境

a. 安裝 postgres server
原則上裝 Windows x86-64	, 除非是你電腦是 32 bit 的(這年頭應該沒有了)
https://www.postgresql.org/download/
b. 一路 next 
c. 輸入 data location
d. 到輸入密碼的地方, 密碼自由輸入, 但建議不要是自己的常用密碼, 因為等下我們會把它寫在檔案裏面進行連線用, 寫個簡單的拋棄式密碼就好.
e. port 保持 5432 (default), 除非你 port 被占用可以換別的. (但基本上不太可能)

5. 檢查 PG 有沒有正常安裝(開啟 pgadmin, 一個品質很差的東西, 頂著先, 假設真的要用的話我建議裝 dbeaver.)

a. 

6. 安裝連線 pg 需要用的東西 (nuget)

a. 專案上按右鍵, 選擇管理 nuget 套件
b. 選擇[瀏覽] 搜尋 Npgsql.EntityFrameworkCore.PostgreSQL 套件
	(打 npgsql 搜尋找名字一樣的 )
c. 選擇安裝/ 按授權同意(我接受), 然後等待安裝



7. 開始寫程式先把跟 db 連結的部分寫起來 (DBContext)

a. 在核心資料夾建立 EFModel 資料夾
b. 建立類別 PracticeContext , 內容為

using dotnetcore_practice.EFModel.Practice;
using Microsoft.EntityFrameworkCore;

namespace dotnetcore_practice.EFModel
{
    public class PracticeContext : DbContext
    {
        public virtual DbSet<Post> Posts { get; set; }      
    }
}

這個檔案是負責來跟特定 DB 做溝通的, 接下來要建立跟資料表溝通的類別, 也就是上面的 Post

c. 建立 EFModel 下的資料夾, Practice 資料夾, 將跟 Practice database 相關的類別歸檔,
   然後建立 Post 類別, 內容為

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnetcore_practice.EFModel.Practice
{

    [Table("posts")]
    public class Post
    {
        [Key]
        public long? ID { get; set; }
        [Column("user_id")]
        public long? userID { get; set; }
        [Column]
        public string title { get; set; }
        [Column]
        public string content { get; set; }
        [Column("create_date")]
        public DateTime? createDate { get; set; } 
    }
}


以下部分現場教學說明

8. 整合 mvc core 

9. 開發


