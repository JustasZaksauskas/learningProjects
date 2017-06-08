create database TWork;

create table user_reg
(
ID INT primary key auto_increment,
Username VARCHAR(90) UNIQUE,
Name VARCHAR(90),
Surname VARCHAR(90),
Email VARCHAR(90),
Password VARCHAR(90),
Address VARCHAR(90),
PhoneNumber VARCHAR(90),
AvatarIMG BLOB,
RegDate datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
Active tinyint(1),
Userlevel tinyint(1)
)

create table cities
(
ID INT primary key auto_increment,
City VARCHAR(90) UNIQUE
)
create table trips
(
ID INT primary key auto_increment,
CityFrom VARCHAR(90) NOT NULL,
CityTo VARCHAR(90) NOT NULL,
TripDate DATE NOT NULL,
TripTime TIME NOT NULL,
UserID INT,
Comments VARCHAR(500)
)

insert into cities (city) values ('Alytus'),('Anykščiai'),('Biržai'),('Druskininkai'),('Ignalina'),('Jonava'),('Joniškis'),
('Jurbarkas'),('Kaunas'),('Kėdainiai'),('Klaipėda'),('Kretinga'),('Kupiškis'),('Lazdijai'),('Marijampolė'),('Mažeikiai'),
('Molėtai'),('N. Akmenė'),('Nida'),('Pakruojis'),('Palanga'),('Panevėžys'),('Pasvalys'),('Plungė'),('Prienai'),('Radviliškis'),
('Rokiškis'),('Skuodas'),('Šakiai'),('Šalčininkai'),('Šiauliai'),('Šilalė'),('Šilutė'),('Švenčionys'),('Tauragė'),('Telšiai'),
('Trakai'),('Ukmergė'),('Utena'),('Varėna'),('Vilkaviškis'),('Vilnius'),('Visaginas'),('Zarasai');

select * from cities;
select * from user_reg;
TRUNCATE TABLE  user_reg;

