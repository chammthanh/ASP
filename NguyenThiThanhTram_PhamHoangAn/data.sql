insert into account values(N'admin',N'admin@gmail.com','12345','1999-11-01',0,1)
insert into account values(N'thanhcham',N'thanhcham@abc.com','12345','2001-11-03',1,2)
insert into account values(N'hoangan',N'hoangan@gmail.com','12345','2001-12-01',0,2)
insert into Account values(N'ermeon',N'abcd@gmail.com','aaaaa','1998-04-23',1,2)
go
insert into Product_Type values(N'Bánh Kem')
insert into Product_Type values(N'CupCake')
insert into Product_Type values(N'Bánh mì')
go
insert into Product_Size values(N'S')
insert into Product_Size values(N'M')
insert into Product_Size values(N'L')
go
insert into Image values(N'product-1.jpg');
insert into Image values(N'product-2.jpg');
insert into Image values(N'product-3.jpg');
insert into Image values(N'product-4.jpg');
insert into Image values(N'product-5.jpg');
insert into Image values(N'product-6.jpg');
insert into Image values(N'product-7.jpg');
insert into Image values(N'product-8.jpg');
insert into Image values(N'product-9.jpg');

go
insert into Product values(N'Bánh kem socolate CupCakes',N'Lorem ipsum dolor sit amet, consectetur adipiscing elit',1,0);
insert into Product values(N'Bánh Kem Matcha',N'Lorem ipsum dolor sit amet, consectetur adipiscing elit',1,0);
insert into Product values(N'Bánh Kem Dâu',N'Lorem ipsum dolor sit amet, consectetur adipiscing elit',1,0);
insert into Product values(N'Chocolate CupCakes',N'Lorem ipsum dolor sit amet, consectetur adipiscing elit',2,0);
insert into Product values(N'Dozen CupCakes',N'Lorem ipsum dolor sit amet, consectetur adipiscing elit',2,0);
insert into Product values(N'RedVelvet CupCakes',N'Lorem ipsum dolor sit amet, consectetur adipiscing elit',2,0);
insert into Product values(N'Bánh Mì Hoa Cúc',N'Lorem ipsum dolor sit amet, consectetur adipiscing elit',3,0);
insert into Product values(N'Bánh Mì Sandwich',N'Lorem ipsum dolor sit amet, consectetur adipiscing elit',3,0);
insert into Product values(N'Bánh Mì Bơ Tỏi',N'Lorem ipsum dolor sit amet, consectetur adipiscing elit',3,0);
go

insert into Product_Detail values(2,1,'2021-12-24',10,'150000','2021-12-24','2021-01-01',1);
insert into Product_Detail values(3,1,'2021-12-24',15,'200000','2021-12-24','2021-01-01',1);

insert into Product_Detail values(2,2,'2021-12-10',5,'230000','2021-12-29','2021-01-10',2);
insert into Product_Detail values(3,2,'2021-12-10',10,'260000','2021-12-29','2021-01-10',2);

insert into Product_Detail values(2,3,'2021-10-25',12,'100000','2021-12-24','2021-01-01',3);
insert into Product_Detail values(3,3,'2021-10-25',10,'190000','2021-12-24','2021-01-01',3);

insert into Product_Detail values(1,4,'2021-01-20',50,'20000','2021-12-24','2021-01-01',4);
insert into Product_Detail values(1,5,'2021-01-10',30,'20000','2021-12-24','2021-01-01',5);
insert into Product_Detail values(1,6,'2021-02-10',70,'25000','2021-12-24','2021-01-01',6);

insert into Product_Detail values(2,7,'2021-06-09',10,'90000','2021-12-24','2021-01-01',7);
insert into Product_Detail values(1,8,'2021-03-15',30,'50000','2021-12-24','2021-01-01',8);
insert into Product_Detail values(1,9,'2021-11-10',20,'20000','2021-12-24','2021-01-01',9);
go
insert into Discount values('KhongGiam',0,'12-12-2021 12:12:00','23:00:00',0);
insert into Discount values('Sale50',50,'12-12-2021 12:12:00','23:00:00',0);
insert into Discount values('TET',10,'1-1-2022 00:00:00','23:00:00',0);
go

insert into Invoice values(1,2,'2021-06-12 11:00:00','2021-06-12 11:00:00',N'Nến số 21',0);
insert into Invoice values(1,2,'2021-12-12 08:00:00','2021-12-12 08:00:00',N'',0);
insert into Invoice values(1,2,'2021-12-25 08:00:00','2021-12-25 08:00:00',N'Thêm đĩa',0);

insert into Invoice values(1,3,'2021-01-09 11:00:00','2021-01-09 11:00:00',N'',0);
insert into Invoice values(1,3,'2021-06-25 10:00:00','2021-06-25 10:00:00',N'Ghi thêm chữ HAPPY BIRTHDAY',0);
insert into Invoice values(1,3,'2021-12-12 08:00:00','2021-12-12 08:00:00',N'Nến số 18',0);

insert into Invoice values(1,4,'2021-05-12 09:00:00','2021-05-12 09:00:00',N'',0);
insert into Invoice values(1,4,'2021-09-01 11:00:00','2021-09-01 11:00:00',N'',0);
insert into Invoice values(1,4,'2021-12-12 11:00:00','2021-12-12 11:00:00',N'Nến số 10',0)
go

insert into Invoice_Detail values(2,1,1,'200000')
insert into Invoice_Detail values(7,2,4,'80000')
insert into Invoice_Detail values(4,3,1,'260000')

insert into Invoice_Detail values(12,4,2,'40000')
insert into Invoice_Detail values(10,5,10,'900000')
insert into Invoice_Detail values(9,6,4,'100000')

insert into Invoice_Detail values(5,7,1,'100000')
insert into Invoice_Detail values(4,8,4,'1040000')
insert into Invoice_Detail values(3,9,2,'460000')
go


insert into List_Address values(2,N'Thanh Trâm','0123456789',N'49 Huỳnh Khương An, Quận Gò Vấp,TP Hồ Chí Minh',1)
insert into List_Address values(3,N'Hoàng An','0555556789',N'65 Huỳnh Phúc Kháng, Quận 1, TP Hồ Chí Minh',1)
insert into List_Address values(4,N'Nguyễn A','0123400000',N'Bàu Bàng , Bình Dương',1)
go

