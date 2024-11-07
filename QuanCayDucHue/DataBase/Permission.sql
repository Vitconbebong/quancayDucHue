sp_Addlogin 'ADMIN', 'ADMIN', 'QuanLyBanHang'
go

sp_Grantdbaccess 'ADMIN', 'DUCHUE'
go

Grant Select, insert,update, delete on DMKhach To DUCHUE
go

Grant Select,insert,update, delete on DMHang To DUCHUE
go

Grant Select,insert,update, delete on HoaDonBan To DUCHUE
go

Grant Select,insert,update, delete on ChiTietHoaDon To DUCHUE
go