using System;

namespace iamhere.Requests
{
    /// <summary>
    /// Is used to show available territories through the point of view of particular countries.
    /// </summary>
    public enum PoliticalView
    {
        /// <summary>
        /// Used to show territories in a neutrally way for the international community.
        /// </summary>
        Default = 0,

        /// <summary>
        /// Shows the Falkland Islands, South Georgia and South Sandwich Islands  as part of Argentina's "Tierra Del Fuego".
        /// </summary>
        Argentina = 1,

        /// <summary>
        /// Shows the Halaib Triangle as a part of Egypt.
        /// </summary>
        Egypt = 2,

        /// <summary>
        /// Shows Northern Cyprus as a part of Cyprus.
        /// </summary>
        Greece = 3,

        /// <summary>
        /// Shows Northern Arunachal Pradesh as a part of the Indian State of Arunachal Pradesh.
        /// Shows Kaurik as a part of the Indian State of Himachal Pradesh.
        /// Shows Lapthal as a part of the Indian State of Uttarakhand.
        /// Shows Sang as a part of the Indian State of Uttarakhand.
        /// Shows Aksai Chin (Kashmir) as a part of the Indian State of Jammu & Kashmir.
        /// Shows Azad Kashmir (Kashmir) as a part of the Indian State of Jammu & Kashmir.
        /// Shows Gilgit-Baltistan (Kashmir) as a part of the Indian State of Jammu & Kashmir.
        /// Shows Pa-li-chia-ssu (Kashmir) as a part of the Indian State of Jammu & Kashmir.
        /// Shows Shaksam Valley (Kashmir) as a part of the Indian State of Jammu & Kashmir.
        /// Shows the State of Jammu & Kashmir (Kashmir) as a part of the Indian State of Jammu & Kashmir.
        /// </summary>
        India = 4,

        /// <summary>
        /// Shows East Jerusalem as a part of Israel.
        /// </summary>
        Israel = 5,

        /// <summary>
        /// Shows the Ilemi Triangle as a part of Kenya.
        /// </summary>
        Kenya = 6,

        /// <summary>
        /// Shows Western Sahara as a part of Morocco.
        /// </summary>
        Morocco = 7,

        /// <summary>
        /// Shows Aksai Chin (Kashmir) as a part of China.
        /// Shows Azad Kashmir (Kashmir) as a part of Pakistan.
        /// Shows Gilgit-Baltistan (Kashmir) as a part of Pakistan.
        /// Shows Pa-li-chia-ssu (Kashmir) as a part of Pakistan.
        /// Shows Shaksam Valley (Kashmir) as a part of China.
        /// Shows the State of Jammu & Kashmir (Kashmir) as a part of Pakistan.
        /// </summary>
        Pakistan = 8,

        /// <summary>
        /// Shows Crimea as a part of Russia.
        /// Shows the Kuril Islands as a part of Russia.
        /// </summary>
        Russia = 9,

        /// <summary>
        /// Shows Northern Cyprus as the Turkish Republic of Northern Cyprus.
        /// Shows Southern Cyprus as the Greek Cypriot Admin of Southern Cyprus.
        /// </summary>
        Turkey = 10,

        /// <summary>
        /// Shows the Paracel Islands as Vietnamese Islands.
        /// Shows the Spratly Islands as Vietnamese Islands.
        /// </summary>
        Vietnam = 11,

        /// <summary>
        /// Shows Abu Musa Islands as a part of the United Arab Emirates.
        /// Shows Tunb Islands as a part of the United Arab Emirates.
        /// </summary>
        UnitedArabEmirates = 12
    }

    public static class PoliticalViewExtensions
    {
        public static string ToCamelCaseString(this PoliticalView politicalView)
        {
            switch (politicalView)
            {
                case PoliticalView.Argentina:
                    return "ARG";
                case PoliticalView.Egypt:
                    return "EGY";
                case PoliticalView.Greece:
                    return "GRC";
                case PoliticalView.India:
                    return "IND";
                case PoliticalView.Israel:
                    return "ISR";
                case PoliticalView.Kenya:
                    return "KEN";
                case PoliticalView.Morocco:
                    return "MAR";
                case PoliticalView.Pakistan:
                    return "PAK";
                case PoliticalView.Russia:
                    return "RUS";
                case PoliticalView.Turkey:
                    return "TUR";
                case PoliticalView.Vietnam:
                    return "VNM";
                case PoliticalView.UnitedArabEmirates:
                    return "ARE";
                case PoliticalView.Default:
                    return string.Empty;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}