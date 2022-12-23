namespace BeautyBooking.Common
{
    public static class GlobalConstants
    {
        public const string SystemName = "BeautySalon";

        public const string AdministratorRoleName = "Administrator";

        public const string SalonManagerRoleName = "Manager";

        public const string CloudName = "beauty-booking";

        public static class AccountsSeeding
        {
            public const string Password = "123456";

            public const string AdminEmail = "admin@admin.com";

            public const string SalonManagerEmail = "manager@manager.com";

            public const string UserEmail = "user@user.com";
        }

        public static class DataValidations
        {
            public const int TitleMaxLength = 60;

            public const int TitleMinLength = 5;

            public const int ContentMaxLength = 500;

            public const int ContentMinLength = 100;

            public const int NameMaxLength = 40;

            public const int NameMinLength = 2;

            public const int DescriptionMaxLength = 500;

            public const int DescriptionMinLength = 50;

            public const int AddressMaxLength = 100;

            public const int AddressMinLength = 5;
        }

        public static class ErrorMessages
        {
            public const string Title = "Заголовок должен содержать от 5 до 60 знаков.";

            public const string Content = "Текст должен содержать от 700 до 3500 знаков.";

            public const string Author = "Имя автора должно содержать от 2 до 40 знаков.";

            public const string Name = "Имя должно содеражать от 2 до 40 знаков.";

            public const string Description = "Описание должно содержать от  50 до 700 знаков.";

            public const string Address = "Адрес должен содержать от 5 до 100 знаков.";

            public const string Image = "Пожалуйста, выберите картинку меньше 1МБ в формате  JPG, JPEG или PNG.";

            public const string DateTime = "Укажите правильное время и дату на календаре.";

            public const string Rating = "Для оценки выберите  от 1 до 5 звездочек.";
        }

        public static class DateTimeFormats
        {
            public const string DateFormat = "dd-MM-yyyy";

            public const string TimeFormat = "HH:mm";

            public const string DateTimeFormat = "dd-MM-yyyy HH:mm";
        }

        public static class Images
        {
            /*public const string Index = "https://res.cloudinary.com/beauty-booking/image/upload/v1586874219/index_iyfzwc.jpg"*/
            
            public const string Index = "https://priroda.club/uploads/posts/2021-12/1638996951_7-priroda-club-p-gori-kirgizii-priroda-krasivo-foto-7.jpg";

            public const string CoverBackground = "https://res.cloudinary.com/beauty-booking/image/upload/v1586874218/cover-bg_nnwh6d.jpg";

            public const string Footer = "https://res.cloudinary.com/beauty-booking/image/upload/v1586874219/footer_rvuuls.jpg";

            public const string Error404 = "https://seranking.com/blog/wp-content/uploads/2021/01/404_01-min.jpg";

            public const string CloudinaryMissing = "https://res.cloudinary.com/beauty-booking/image/upload/v1587708556/cloudinary_veibtu.png";

            // BlogPosts
            public const string SummerHealthyHair = "https://i.pinimg.com/originals/f9/4a/85/f94a852ef9ccdcde8d1ce00034a0e3ea.jpg";

            public const string MakeUp = "https://i.pinimg.com/originals/f9/4a/85/f94a852ef9ccdcde8d1ce00034a0e3ea.jpg";

            public const string SummerBeautyTips = "https://i.pinimg.com/originals/f9/4a/85/f94a852ef9ccdcde8d1ce00034a0e3ea.jpg";

            public const string StressedSkin = "https://i.pinimg.com/originals/f9/4a/85/f94a852ef9ccdcde8d1ce00034a0e3ea.jpg";

            // Categories
            public const string Hair = "https://avatars.mds.yandex.net/i?id=02a3902cbaa4d4303f45e745e70ce4e486d31d2c-8350569-images-thumbs&n=13";

            public const string HairRemoval = "https://i.pinimg.com/originals/f9/4a/85/f94a852ef9ccdcde8d1ce00034a0e3ea.jpg";

            public const string Massage = "https://i.pinimg.com/originals/f9/4a/85/f94a852ef9ccdcde8d1ce00034a0e3ea.jpg";

            public const string Nails = "https://i.pinimg.com/originals/f9/4a/85/f94a852ef9ccdcde8d1ce00034a0e3ea.jpg";

            public const string Face = "https://i.pinimg.com/originals/f9/4a/85/f94a852ef9ccdcde8d1ce00034a0e3ea.jpg";

            public const string Body = "https://st3.depositphotos.com/4133785/16848/i/600/depositphotos_168480004-stock-photo-beautiful-kazakh-woman-in-national.jpg";

            // Salons
            public const string Hair1 = "https://i.pinimg.com/originals/f9/4a/85/f94a852ef9ccdcde8d1ce00034a0e3ea.jpg";

            public const string Hair2 = "https://i.pinimg.com/originals/f9/4a/85/f94a852ef9ccdcde8d1ce00034a0e3ea.jpg";

            public const string Hair3 = "https://i.pinimg.com/originals/f9/4a/85/f94a852ef9ccdcde8d1ce00034a0e3ea.jpg";

            public const string HairRemoval1 = "https://i.pinimg.com/originals/f9/4a/85/f94a852ef9ccdcde8d1ce00034a0e3ea.jpg";

            public const string HairRemoval2 = "https://i.pinimg.com/originals/f9/4a/85/f94a852ef9ccdcde8d1ce00034a0e3ea.jpg";

            public const string HairRemoval3 = "https://i.pinimg.com/originals/f9/4a/85/f94a852ef9ccdcde8d1ce00034a0e3ea.jpg";

            public const string Massage1 = "https://i.pinimg.com/originals/f9/4a/85/f94a852ef9ccdcde8d1ce00034a0e3ea.jpg";

            public const string Massage2 = "https://i.pinimg.com/originals/f9/4a/85/f94a852ef9ccdcde8d1ce00034a0e3ea.jpg";

            public const string Massage3 = "https://i.pinimg.com/originals/f9/4a/85/f94a852ef9ccdcde8d1ce00034a0e3ea.jpg";

            public const string Nails1 = "https://i.pinimg.com/originals/f9/4a/85/f94a852ef9ccdcde8d1ce00034a0e3ea.jpg";

            public const string Nails2 = "https://i.pinimg.com/originals/f9/4a/85/f94a852ef9ccdcde8d1ce00034a0e3ea.jpg";

            public const string Nails3 = "https://i.pinimg.com/originals/f9/4a/85/f94a852ef9ccdcde8d1ce00034a0e3ea.jpg";

            public const string Face1 = "https://i.pinimg.com/originals/f9/4a/85/f94a852ef9ccdcde8d1ce00034a0e3ea.jpg";

            public const string Face2 = "https://i.pinimg.com/originals/f9/4a/85/f94a852ef9ccdcde8d1ce00034a0e3ea.jpg";

            public const string Face3 = "https://i.pinimg.com/originals/f9/4a/85/f94a852ef9ccdcde8d1ce00034a0e3ea.jpg";

            public const string Body1 = "https://i.pinimg.com/originals/f9/4a/85/f94a852ef9ccdcde8d1ce00034a0e3ea.jpg";

            public const string Body2 = "https://i.pinimg.com/originals/f9/4a/85/f94a852ef9ccdcde8d1ce00034a0e3ea.jpg";

            public const string Body3 = "https://avatars.mds.yandex.net/i?id=ffca6e9036276296c13a528025c6d66f3a25ca34-3996309-images-thumbs&n=13";
        }

        public static class SeededDataCounts
        {
            public const int BlogPosts = 4;

            public const int Categories = 6;

            public const int Services = 55;

            public const int Cities = 2;

            public const int Salons = 18;

            public const int Appointments = 54;
        }
    }
}
