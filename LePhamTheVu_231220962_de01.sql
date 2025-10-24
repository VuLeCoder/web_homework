use master
go

create database LePhamTheVu_231220962_de01
go

use LePhamTheVu_231220962_de01
go

CREATE TABLE lptvComputer (
    LePhamTheVuComId NVARCHAR(450) NOT NULL PRIMARY KEY,  
    LePhamTheVuComName NVARCHAR(50) NOT NULL,             
    LePhamTheVuComPrice DECIMAL(18,2) NOT NULL,           
    LePhamTheVuComImage NVARCHAR(MAX) NULL,               
    LePhamTheVuComStatus BIT NOT NULL                     
);


insert into lptvComputer values
('LPTV231220962', N'Lê Phạm Thế Vũ', 2209, '', 1),
('LPTV002', N'LaptopA', 100, '', 1),
('LPTV003', N'LaptopB', 100, '', 0),
('LPTV004', N'LaptopC', 100, '', 0)

select * from lptvComputer