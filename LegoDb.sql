CREATE TABLE Sets
(
	name		varchar(200) not null,
	description	varchar(1024) not null,
	pieces      int not null,
	imageName	varchar(1024) not null	
);

insert into Sets values ('Death Star', 'Win the battle for the Empire with the awesome Death Star!', 4016, 'DeathStar.jpg');

insert into Sets values ('The Mountain Cave', 'Experience the Mountain Cave!', 2863, 'MountainCave.jpg');

insert into Sets values ('The Ultimate Batmobile', 'Divide the 4-in-1 Ultimate Batmobile and conquer the Super-Villains!', 1456, 'Batmobile.jpg');