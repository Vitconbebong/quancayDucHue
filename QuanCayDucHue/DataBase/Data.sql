create database QuanLyBanHang
go

use QuanLyBanHang
go

create table DMKhach
(
 MaKhach char (15) primary key,
 TenKhach nchar (20) not null,
 QueQuan nchar (25) not null,
 DienThoai char (11) not null
)
go


create table DMHang
(
 MaHang char (15) primary key,
 TenHang nchar (10) not null,
 DVT nchar (20) not null,
 NOI_SX nchar (25) not null
)
go


create table HoaDonBan
(
 SoHD char (15) primary key,
 MaKhach char (15) foreign key (MaKhach) references DMKhach(MaKhach),
 NgayHD date not null,
 DienGiai nchar(15) not null
)
go


create table ChiTietHoaDon
(
 SoHD char (15) ,
 MaHang char (15) ,
 primary key (SoHD,MaHang),
 SoLuong int not null,
 DonGia smallmoney not null
 constraint KN1 foreign key (SoHD) references HoaDonBan(SoHD),
 constraint KN2 foreign key (MaHang) references DMHang(MaHang)
)
go

insert into DMKhach values 
('KH001', N'Nguyễn Văn A', N'Hà Nội', '0912345678'),
('KH002', N'Trần Thị B', N'Hồ Chí Minh', '0909876543'),
('KH003', N'Lê Minh C', N'Đà Nẵng', '0987654321'),
('KH004', N'Phạm Hoàng D', N'Hải Phòng', '0932123456'),
('KH005', N'Ngô Thanh E', N'Nghệ An', '0976543210'),
('KH006', N'Lý Thị F', N'Bình Dương', '0911122334'),
('KH007', N'Võ Văn G', N'Đồng Nai', '0909988776'),
('KH008', N'Đặng Quang H', N'Hà Tĩnh', '0988776655'),
('KH009', N'Trương Minh I', N'Bình Định', '0912233445'),
('KH010', N'Hoàng Kim J', N'Quảng Bình', '0933445566'),
('KH011', N'Phan Thanh K', N'Quảng Nam', '0922334455'),
('KH012', N'Vũ Thị L', N'Quảng Ngãi', '0988665544'),
('KH013', N'Nguyễn Văn M', N'Khánh Hòa', '0900112233'),
('KH014', N'Trần Minh N', N'Ninh Thuận', '0911445566'),
('KH015', N'Lê Thị O', N'Bình Thuận', '0922556677'),
('KH016', N'Phạm Văn P', N'Kon Tum', '0933667788'),
('KH017', N'Đinh Minh Q', N'Gia Lai', '0944778899'),
('KH018', N'Vương Thị R', N'Đắk Lắk', '0955889900'),
('KH019', N'Mai Văn S', N'Đắk Nông', '0912990099'),
('KH020', N'Lê Minh T', N'Lâm Đồng', '0909888776'),
('KH021', N'Trịnh Thị U', N'Bình Phước', '0977886655'),
('KH022', N'Hoàng Văn V', N'Tây Ninh', '0988776544'),
('KH023', N'Nguyễn Thị X', N'Bình Dương', '0945667788'),
('KH024', N'Lê Minh Y', N'Đồng Tháp', '0934556677'),
('KH025', N'Phan Văn Z', N'Long An', '0911445566'),
('KH026', N'Võ Quang AA', N'Bà Rịa - Vũng Tàu', '0922778899'),
('KH027', N'Dương Thị BB', N'Tp. Hồ Chí Minh', '0934889900'),
('KH028', N'Triệu Minh CC', N'Tiền Giang', '0911990099'),
('KH029', N'Hoàng Văn DD', N'Hậu Giang', '0909888776'),
('KH030', N'Nguyễn Thị EE', N'Vĩnh Long', '0977886655'),
('KH031', N'Trần Văn FF', N'Cần Thơ', '0988776544'),
('KH032', N'Lý Minh GG', N'Hà Giang', '0945667788'),
('KH033', N'Vũ Thị HH', N'Cao Bằng', '0934556677'),
('KH034', N'Nguyễn Văn II', N'Bắc Kạn', '0911445566'),
('KH035', N'Trương Minh JJ', N'Thái Nguyên', '0922778899'),
('KH036', N'Phạm Thị KK', N'Vĩnh Phúc', '0934889900'),
('KH037', N'Vương Văn LL', N'Phú Thọ', '0911990099'),
('KH038', N'Mai Thị MM', N'Hòa Bình', '0909888776'),
('KH039', N'Tạ Văn NN', N'Sơn La', '0977886655'),
('KH040', N'Đinh Minh OO', N'Yên Bái', '0988776544'),
('KH041', N'Võ Thị PP', N'Thái Bình', '0945667788'),
('KH042', N'Lê Văn QQ', N'Nam Định', '0934556677'),
('KH043', N'Nguyễn Minh RR', N'Hải Dương', '0911445566'),
('KH044', N'Trần Thị SS', N'Hưng Yên', '0922778899'),
('KH045', N'Hoàng Minh TT', N'Hà Nam', '0934889900'),
('KH046', N'Phan Văn UU', N'Ninh Bình', '0911990099'),
('KH047', N'Vũ Thị VV', N'Thanh Hóa', '0909888776'),
('KH048', N'Nguyễn Văn WW', N'Nghệ An', '0977886655'),
('KH049', N'Trần Thanh XX', N'Hà Tĩnh', '0988776544'),
('KH050', N'Lê Minh YY', N'Quảng Bình', '0945667788');
go


insert into DMHang values
('H001', N'Hàng A', N'Chiếc', N'Thái Nguyên'),
('H002', N'Hàng B', N'Chai', N'Cao Bằng'),
('H003', N'Hàng C', N'Cái', N'Thái Nguyên'),
('H004', N'Hàng D', N'Lon', N'Cao Bằng'),
('H005', N'Hàng E', N'Kilogram', N'Hà Nội'),
('H006', N'Hàng F', N'Hộp', N'Quảng Ninh'),
('H007', N'Hàng G', N'Bao', N'Cao Bằng'),
('H008', N'Hàng H', N'Túi', N'Thái Nguyên'),
('H009', N'Hàng I', N'Gói', N'Đắk Lắk'),
('H010', N'Hàng J', N'Kilogram', N'Cao Bằng'),
('H011', N'Hàng K', N'Chai', N'Quảng Ninh'),
('H012', N'Hàng L', N'Lon', N'Hải Phòng'),
('H013', N'Hàng M', N'Bao', N'Thái Nguyên'),
('H014', N'Hàng N', N'Túi', N'Hà Nội'),
('H015', N'Hàng O', N'Gói', N'Cao Bằng'),
('H016', N'Hàng P', N'Hộp', N'Thái Nguyên'),
('H017', N'Hàng Q', N'Chiếc', N'Hải Phòng'),
('H018', N'Hàng R', N'Chai', N'Hà Nội'),
('H019', N'Hàng S', N'Túi', N'Cao Bằng'),
('H020', N'Hàng T', N'Lon', N'Thái Nguyên'),
('H021', N'Hàng U', N'Kilogram', N'Hà Nội'),
('H022', N'Hàng V', N'Gói', N'Quảng Ninh'),
('H023', N'Hàng W', N'Chiếc', N'Hải Phòng'),
('H024', N'Hàng X', N'Hộp', N'Cao Bằng'),
('H025', N'Hàng Y', N'Bao', N'Thái Nguyên'),
('H026', N'Hàng Z', N'Kilogram', N'Hà Nội'),
('H027', N'Hàng AA', N'Chai', N'Cao Bằng'),
('H028', N'Hàng BB', N'Túi', N'Quảng Ninh'),
('H029', N'Hàng CC', N'Hộp', N'Cao Bằng'),
('H030', N'Hàng DD', N'Bao', N'Thái Nguyên'),
('H031', N'Hàng EE', N'Chiếc', N'Hải Phòng'),
('H032', N'Hàng FF', N'Kilogram', N'Hà Nội'),
('H033', N'Hàng GG', N'Lon', N'Cao Bằng'),
('H034', N'Hàng HH', N'Chai', N'Quảng Ninh'),
('H035', N'Hàng II', N'Gói', N'Cao Bằng'),
('H036', N'Hàng JJ', N'Túi', N'Thái Nguyên'),
('H037', N'Hàng KK', N'Hộp', N'Quảng Ninh'),
('H038', N'Hàng LL', N'Bao', N'Cao Bằng'),
('H039', N'Hàng MM', N'Kilogram', N'Thái Nguyên'),
('H040', N'Hàng NN', N'Chiếc', N'Cao Bằng'),
('H041', N'Hàng OO', N'Gói', N'Hà Nội'),
('H042', N'Hàng PP', N'Túi', N'Quảng Ninh'),
('H043', N'Hàng QQ', N'Chai', N'Cao Bằng'),
('H044', N'Hàng RR', N'Hộp', N'Thái Nguyên'),
('H045', N'Hàng SS', N'Bao', N'Hải Phòng'),
('H046', N'Hàng TT', N'Kilogram', N'Cao Bằng'),
('H047', N'Hàng UU', N'Lon', N'Quảng Ninh'),
('H048', N'Hàng VV', N'Chiếc', N'Cao Bằng'),
('H049', N'Hàng WW', N'Túi', N'Thái Nguyên'),
('H050', N'Hàng XX', N'Gói', N'Hà Nội');
go


insert into HoaDonBan values
('HD001', 'KH001', '2014-03-15', N'Hóa đơn 001'),
('HD002', 'KH030', '2014-05-20', N'Hóa đơn 002'),
('HD003', 'KH009', '2014-07-10', N'Hóa đơn 003'),
('HD004', 'KH030', '2014-09-05', N'Hóa đơn 004'),
('HD005', 'KH012', '2014-11-30', N'Hóa đơn 005'),
('HD006', 'KH006', '2015-02-18', N'Hóa đơn 006'),
('HD007', 'KH030', '2015-04-25', N'Hóa đơn 007'),
('HD008', 'KH010', '2015-06-08', N'Hóa đơn 008'),
('HD009', 'KH009', '2015-08-17', N'Hóa đơn 009'),
('HD010', 'KH009', '2015-10-22', N'Hóa đơn 010'),
('HD011', 'KH011', '2016-01-14', N'Hóa đơn 011'),
('HD012', 'KH012', '2016-03-02', N'Hóa đơn 012'),
('HD013', 'KH012', '2016-05-09', N'Hóa đơn 013'),
('HD014', 'KH014', '2016-07-11', N'Hóa đơn 014'),
('HD015', 'KH015', '2016-09-19', N'Hóa đơn 015'),
('HD016', 'KH050', '2014-04-12', N'Hóa đơn 016'),
('HD017', 'KH009', '2014-06-21', N'Hóa đơn 017'),
('HD018', 'KH018', '2014-08-05', N'Hóa đơn 018'),
('HD019', 'KH047', '2014-10-10', N'Hóa đơn 019'),
('HD020', 'KH034', '2014-12-27', N'Hóa đơn 020'),
('HD021', 'KH021', '2015-03-23', N'Hóa đơn 021'),
('HD022', 'KH022', '2015-05-28', N'Hóa đơn 022'),
('HD023', 'KH023', '2015-07-15', N'Hóa đơn 023'),
('HD024', 'KH024', '2015-09-29', N'Hóa đơn 024'),
('HD025', 'KH047', '2015-11-03', N'Hóa đơn 025'),
('HD026', 'KH050', '2016-02-07', N'Hóa đơn 026'),
('HD027', 'KH015', '2016-04-18', N'Hóa đơn 027'),
('HD028', 'KH047', '2016-06-25', N'Hóa đơn 028'),
('HD029', 'KH029', '2016-08-13', N'Hóa đơn 029'),
('HD030', 'KH050', '2016-10-20', N'Hóa đơn 030'),
('HD031', 'KH031', '2014-03-08', N'Hóa đơn 031'),
('HD032', 'KH015', '2014-05-16', N'Hóa đơn 032'),
('HD033', 'KH023', '2014-07-21', N'Hóa đơn 033'),
('HD034', 'KH034', '2014-09-30', N'Hóa đơn 034'),
('HD035', 'KH010', '2014-11-12', N'Hóa đơn 035'),
('HD036', 'KH036', '2015-02-05', N'Hóa đơn 036'),
('HD037', 'KH050', '2015-04-10', N'Hóa đơn 037'),
('HD038', 'KH015', '2015-06-19', N'Hóa đơn 038'),
('HD039', 'KH023', '2015-08-24', N'Hóa đơn 039'),
('HD040', 'KH040', '2015-10-29', N'Hóa đơn 040'),
('HD041', 'KH050', '2016-01-20', N'Hóa đơn 041'),
('HD042', 'KH050', '2016-03-08', N'Hóa đơn 042'),
('HD043', 'KH012', '2016-05-15', N'Hóa đơn 043'),
('HD044', 'KH044', '2016-07-17', N'Hóa đơn 044'),
('HD045', 'KH050', '2016-09-23', N'Hóa đơn 045'),
('HD046', 'KH046', '2014-04-18', N'Hóa đơn 046'),
('HD047', 'KH047', '2014-06-30', N'Hóa đơn 047'),
('HD048', 'KH048', '2014-08-15', N'Hóa đơn 048'),
('HD049', 'KH049', '2014-10-27', N'Hóa đơn 049'),
('HD050', 'KH050', '2014-12-29', N'Hóa đơn 050');
go


insert into ChiTietHoaDon values 
('HD001', 'H001', 10, 15000.00),
('HD001', 'H002', 5, 25000.00),
('HD002', 'H005', 8, 30000.00),
('HD002', 'H004', 3, 20000.00),
('HD003', 'H005', 12, 5000.00),
('HD003', 'H006', 6, 8000.00),
('HD004', 'H001', 4, 70000.00),
('HD004', 'H018', 10, 12000.00),
('HD005', 'H009', 15, 10000.00),
('HD005', 'H018', 2, 18000.00),
('HD006', 'H015', 7, 35000.00),
('HD006', 'H040', 5, 6000.00),
('HD007', 'H018', 9, 23000.00),
('HD007', 'H014', 3, 28000.00),
('HD008', 'H015', 11, 9000.00),
('HD008', 'H027', 8, 32000.00),
('HD009', 'H017', 6, 40000.00),
('HD009', 'H018', 4, 10000.00),
('HD010', 'H040', 13, 15000.00),
('HD010', 'H015', 2, 21000.00),
('HD011', 'H030', 5, 4500.00),
('HD011', 'H027', 7, 7500.00),
('HD012', 'H023', 9, 60000.00),
('HD012', 'H024', 6, 7000.00),
('HD013', 'H030', 10, 8000.00),
('HD013', 'H025', 4, 4000.00),
('HD014', 'H025', 8, 25000.00),
('HD014', 'H042', 5, 30000.00),
('HD015', 'H029', 12, 18000.00),
('HD015', 'H030', 3, 12000.00),
('HD016', 'H027', 6, 70000.00),
('HD016', 'H046', 9, 10000.00),
('HD017', 'H027', 4, 15000.00),
('HD017', 'H025', 11, 22000.00),
('HD018', 'H040', 7, 17000.00),
('HD018', 'H036', 2, 28000.00),
('HD019', 'H040', 8, 35000.00),
('HD019', 'H025', 5, 5000.00),
('HD020', 'H039', 10, 20000.00),
('HD020', 'H040', 6, 12000.00),
('HD021', 'H041', 3, 45000.00),
('HD021', 'H046', 7, 6000.00),
('HD022', 'H043', 4, 28000.00),
('HD022', 'H044', 9, 8000.00),
('HD023', 'H046', 11, 32000.00),
('HD023', 'H041', 5, 10000.00),
('HD024', 'H042', 6, 40000.00),
('HD024', 'H048', 8, 15000.00),
('HD025', 'H042', 9, 18000.00),
('HD025', 'H050', 12, 25000.00);
go


create trigger updateNonKhach on DMKhach for update as 
	begin 
		declare @newInfo char(15)
		select @newInfo = MaKhach from inserted
		if(not exists(select * from DMKhach where MaKhach = @newInfo))
			begin 
				throw 50000, 'CODE1', 1;
				Rollback tran
			end
	end
go

create trigger updateNonHang on DMHang for update as 
	begin 
		declare @newInfo char(15)
		select @newInfo = MaHang from inserted
		if(not exists(select * from DMHang where MaHang = @newInfo))
			begin 
				throw 50000, 'CODE2', 1;
				Rollback tran
			end
	end
go


create trigger updateNonHoaDon on HoaDonBan for update as 
	begin 
		declare @newInfo char(15)
		select @newInfo = SoHD from inserted
		if(not exists(select * from HoaDonBan where SoHD = @newInfo))
			begin 
				throw 50000, 'CODE3', 1;
				Rollback tran
			end
	end
go


