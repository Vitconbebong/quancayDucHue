# Quản Lý Bán Hàng (QuanCayDucHue)

Đây là ứng dụng quản lý bán hàng được xây dựng trên nền tảng Windows Forms.

## Công nghệ sử dụng

- **Ngôn ngữ**: C#
- **Framework**: .NET Framework 4.7.2
- **Giao diện**: Windows Forms
- **Cơ sở dữ liệu**: SQL Server
- **Kiến trúc**: MVC (Model-View-Controller)

## Cấu trúc dự án

- `QuanLyBanHang/Controllers`: Chứa logic nghiệp vụ và điều khiển.
- `QuanLyBanHang/Models`: Chứa các lớp tương tác với cơ sở dữ liệu (sử dụng ADO.NET).
- `QuanLyBanHang/Views`: Chứa giao diện người dùng (Forms).
- `DataBase`: Chứa các script SQL để khởi tạo cơ sở dữ liệu.

## Hướng dẫn cài đặt và chạy

### 1. Chuẩn bị Cơ sở dữ liệu

1. Mở SQL Server Management Studio (SSMS).
2. Chạy các file script SQL trong thư mục `QuanCayDucHue/DataBase/` theo thứ tự:
   - `Data.sql`: Tạo bảng và dữ liệu mẫu.
   - `Permission.sql`: Thiết lập quyền (nếu có).

### 2. Cấu hình kết nối

Mặc định, chuỗi kết nối đang được cấu hình cho server `VITCONBEBONG`. Bạn cần thay đổi nó để phù hợp với môi trường của bạn.

1. Mở file `QuanCayDucHue/QuanLyBanHang/Models/ADO.cs`.
2. Tìm phương thức `sqlConnection` và biến `connectionString`:
   ```csharp
   string connectionString = $@"server = VITCONBEBONG;
                                database = QuanLyBanHang;
                                user = {username};
                                password = {password};";
   ```
3. Thay đổi `server = VITCONBEBONG` thành tên server SQL của bạn (ví dụ: `server = .\\SQLEXPRESS` hoặc `server = localhost`).

### 3. Chạy ứng dụng

1. Mở file solution `QuanCayDucHue/QuanCayDucHue.sln` bằng Visual Studio.
2. Nhấn **Start** hoặc **F5** để biên dịch và chạy ứng dụng.

## Yêu cầu hệ thống

- Visual Studio (2019 hoặc mới hơn).
- SQL Server.
- .NET Framework 4.7.2.
