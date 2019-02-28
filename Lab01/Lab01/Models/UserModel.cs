using System;


namespace Lab01.Models
{
    [Serializable]
    public class UserModel
    {

        public DateTime Date { get; set; }
        public int Age { get; set; }
        public string ZodiacSign { get; set; }
        public string ChineseSign { get; set; }

        public UserModel()
        {

        }

        public UserModel(DateTime date)
        {
            Date = date;
        }

    }
}
