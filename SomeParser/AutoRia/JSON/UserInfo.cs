using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SomeParser
{
    public class User
    {
        [Key]
        public string user_id { get; set; }
        public string user_id_parent { get; set; }
        public string email { get; set; }
        public string email_normalized { get; set; }
        public string email_normalized_orig { get; set; }
        public string email_verified { get; set; }
        public string state_id { get; set; }
        public string city_id { get; set; }
        public string name { get; set; }
        public string registered_date { get; set; }
        public bool avatar_exists { get; set; }
        public object avatar { get; set; }
        public string project_id { get; set; }
        public string usingSite { get; set; }
        public string lastVisit { get; set; }
        public bool contactViaEmail { get; set; }
        public bool hideRegistration { get; set; }
        public bool isPartner { get; set; }
    }

    public class Company
    {
        [Key]
        public int company_id { get; set; }
        public int user_id { get; set; }
        public int type_id { get; set; }
        public int package_id { get; set; }
        public int package_period { get; set; }
        public int state_id { get; set; }
        public int city_id { get; set; }
        public string name { get; set; }
        public string eng { get; set; }
        public string address { get; set; }
        public object geo_X { get; set; }
        public object geo_Y { get; set; }
        public string teaser { get; set; }
        public string description { get; set; }
        public string add_date { get; set; }
        public string close_date { get; set; }
        public string start_shiping { get; set; }
        public object logo { get; set; }
        public object site_url { get; set; }
        public object minisite_url { get; set; }
        public int minisite { get; set; }
        public int moderated { get; set; }
        public int active { get; set; }
        public int payment_item_id { get; set; }
        public int hasDocuments { get; set; }
        public int isReliable { get; set; }
        public string timetable { get; set; }
        public string exchanges { get; set; }
        public string typeName { get; set; }
        public string typeEng { get; set; }
        public int is_active { get; set; }
        public string pageLink { get; set; }
    }

    public class Autosalon
    {
    }

    public class AdditionalData
    {
        [Key]
        public string phone_id { get; set; }
        public string call_from { get; set; }
        public string call_till { get; set; }
        public string call_name { get; set; }
    }

    public class Phone
    {
        [Key]
        public string phone_id { get; set; }
        public string user_id { get; set; }
        public string phone { get; set; }
        public string region_code_size { get; set; }
        public string @checked { get; set; }
        public string is_mobile { get; set; }
        public string prio { get; set; }
        public string country_code { get; set; }
        public string phone_code { get; set; }
        public string phone_number { get; set; }
        public string phone_formatted { get; set; }
        //public List<AdditionalData> additional_data { get; set; }
        public string callTime { get; set; }
    }

    public class City
    {
        public int langId { get; set; }
        [Key]
        public int cityId { get; set; }
        public int stateId { get; set; }
        public string name { get; set; }
        public string eng { get; set; }
        public string engName { get; set; }
        public string declension { get; set; }
    }

    public class State
    {
        public int langId { get; set; }
        [Key]
        public int stateId { get; set; }
        public string name { get; set; }
        public string eng { get; set; }
        public string engName { get; set; }
        public string declension { get; set; }
        public string centerDeclension { get; set; }
        public string regionName { get; set; }
    }

    public class Social
    {
    }

    public class UserInfo
    {
        [Key]
        public int id { get; set; }
        public User user { get; set; }
        public string userType { get; set; }
        public string minisite { get; set; }
        public Company company { get; set; }
        public Autosalon autosalon { get; set; }
        public List<Phone> phones { get; set; }
        public City city { get; set; }
        public State state { get; set; }
        public Social social { get; set; }
    }
}