using System.Collections.Generic;

namespace SomeParser
{
    public class AdditionalParams
    {
        public int lang_id { get; set; }
        public string page { get; set; }
        public int view_type_id { get; set; }
        public string target { get; set; }
        public string section { get; set; }
        public string catalog_name { get; set; }
        public bool elastica { get; set; }
        public bool nodejs { get; set; }
    }

    public class Level
    {
        public string order { get; set; }
    }

    public class Script
    {
        public string script { get; set; }
        public string type { get; set; }
        public string order { get; set; }
    }

    public class Fishki
    {
        public string order { get; set; }
    }

    public class AddDate
    {
        public string order { get; set; }
    }

    public class Sort
    {
        public Level level { get; set; }
        public Script _script { get; set; }
        public Fishki fishki { get; set; }
        public AddDate add_date { get; set; }
    }

    public class MatchAll
    {
    }

    public class Query2
    {
        public MatchAll match_all { get; set; }
    }

    public class Exists
    {
        public string field { get; set; }
    }

    public class Term
    {
        public int damage { get; set; }
        public int? main_category { get; set; }
    }

    public class RaceInt
    {
        public int gte { get; set; }
        public int lte { get; set; }
    }

    public class Range
    {
        public RaceInt raceInt { get; set; }
    }

    public class Term2
    {
        public int currency_id { get; set; }
        public string marka_id { get; set; }
        public string model_id { get; set; }
    }

    public class Price
    {
        public int lte { get; set; }
        public int gt { get; set; }
    }

    public class Yers
    {
        public string gte { get; set; }
    }

    public class Range2
    {
        public Price price { get; set; }
        public Yers yers { get; set; }
    }

    public class And2
    {
        public Term2 term { get; set; }
        public Range2 range { get; set; }
    }

    public class Or
    {
        public List<And2> and { get; set; }
    }

    public class And
    {
        public Exists exists { get; set; }
        public Term term { get; set; }
        public Range range { get; set; }
        public List<Or> or { get; set; }
    }

    public class Filter
    {
        public List<And> and { get; set; }
    }

    public class Filtered
    {
        public Query2 query { get; set; }
        public Filter filter { get; set; }
    }

    public class Query
    {
        public Filtered filtered { get; set; }
    }

    public class Qs
    {
        public List<string> fields { get; set; }
        public int size { get; set; }
        public int from { get; set; }
        public Sort sort { get; set; }
        public Query query { get; set; }
    }

    public class SearchResult
    {
        public List<string> ids { get; set; }
        public int count { get; set; }
        public int last_id { get; set; }
        public Qs qs { get; set; }
        public string query_string { get; set; }
    }

    public class ActiveMarka
    {
        public int lang_id { get; set; }
        public int marka_id { get; set; }
        public string name { get; set; }
        public string set_cat { get; set; }
        public int main_category { get; set; }
        public int active { get; set; }
        public int country_id { get; set; }
        public string eng { get; set; }
        public int count { get; set; }
        public int fit { get; set; }
    }

    public class ActiveModel
    {
        public int lang_id { get; set; }
        public int model_id { get; set; }
        public int marka_id { get; set; }
        public string name { get; set; }
        public string set_cat { get; set; }
        public int active { get; set; }
        public int is_group { get; set; }
        public int parent_id { get; set; }
        public string eng { get; set; }
        public int count { get; set; }
        public int fit { get; set; }
    }

    public class All
    {
        public string category_id { get; set; }
        public List<string> s_yers { get; set; }
        public List<string> po_yers { get; set; }
        public string price_do { get; set; }
        public string currency { get; set; }
        public List<string> marka_id { get; set; }
        public List<string> model_id { get; set; }
        public int countpage { get; set; }
        public string page { get; set; }
        public string power_name { get; set; }
        public string engineVolumeFrom { get; set; }
        public string engineVolumeTo { get; set; }
        public string raceTo { get; set; }
        public string damage { get; set; }
        public List<object> brandOrigin { get; set; }
        public List<object> excludeMM { get; set; }
        public List<object> state { get; set; }
        public List<object> city { get; set; }
        public List<object> auto_options { get; set; }
        public string target { get; set; }
        public string @event { get; set; }
        public int lang_id { get; set; }
        public object limit_page { get; set; }
        public int last_id { get; set; }
        public int last_search_id { get; set; }
        public int saledParam { get; set; }
        public int state_id { get; set; }
        public int city_id { get; set; }
        public int state_from { get; set; }
        public int city_from { get; set; }
        public List<object> m_state { get; set; }
        public List<object> m_city { get; set; }
        public List<object> marka { get; set; }
        public List<object> model { get; set; }
        public List<object> mm_marka { get; set; }
        public List<object> mm_model { get; set; }
        public List<object> mm_marka_filtr { get; set; }
        public List<object> mm_model_filtr { get; set; }
        public bool useOrigAutoTable { get; set; }
        public bool withoutStatus { get; set; }
        public bool with_photo { get; set; }
        public bool with_video { get; set; }
        public int under_credit { get; set; }
        public int confiscated_car { get; set; }
        public int with_exchange { get; set; }
        public List<object> exchange_filter { get; set; }
        public int with_real_exchange { get; set; }
        public bool old_only { get; set; }
        public int user_id { get; set; }
        public int person_id { get; set; }
        public bool with_discount { get; set; }
        public string auto_id_str { get; set; }
        public int black_user_id { get; set; }
        public int order_by { get; set; }
        public bool is_online { get; set; }
        public bool last_send_id { get; set; }
        public bool withoutCache { get; set; }
        public bool with_last_id { get; set; }
        public int color { get; set; }
        public int color_id { get; set; }
        public int gear_id { get; set; }
        public int gearbox { get; set; }
        public int top { get; set; }
        public int drive_type { get; set; }
        public int country { get; set; }
        public List<object> mm_country { get; set; }
        public List<object> mm_country_exeption { get; set; }
        public int currency_id { get; set; }
        public List<object> currencies_arr { get; set; }
        public int auto_repairs { get; set; }
        public int powerFrom { get; set; }
        public int powerTo { get; set; }
        public List<object> hide_black_list { get; set; }
        public int fuelRateFrom { get; set; }
        public int fuelRateTo { get; set; }
        public int custom { get; set; }
        public List<object> body_id { get; set; }
        public List<object> bodyStyleId { get; set; }
        public int type { get; set; }
        public int metallic { get; set; }
        public int raceFrom { get; set; }
        public int sid { get; set; }
        public int star_auto { get; set; }
        public string start_date { get; set; }
        public int drive_id { get; set; }
        public int door { get; set; }
        public int price_ot { get; set; }
        public int year { get; set; }
        public int auto_ids_search_position { get; set; }
        public int print_qs { get; set; }
        public int last_auto_id { get; set; }
        public int is_hot { get; set; }
        public int deletedAutoSearch { get; set; }
        public int can_be_checked { get; set; }
        public int seatsFrom { get; set; }
        public int seatsTo { get; set; }
        public int wheelFormulaId { get; set; }
        public int axleId { get; set; }
        public int carryingTo { get; set; }
        public int carryingFrom { get; set; }
        public int company_id { get; set; }
        public int company_type { get; set; }
        public int matched_country { get; set; }
        public string q { get; set; }
        public List<object> bodystyle { get; set; }
    }

    public class Cleaned
    {
        public string category_id { get; set; }
        public List<string> s_yers { get; set; }
        public List<string> po_yers { get; set; }
        public string price_do { get; set; }
        public string currency { get; set; }
        public List<string> marka_id { get; set; }
        public List<string> model_id { get; set; }
        public int countpage { get; set; }
        public string power_name { get; set; }
        public string raceTo { get; set; }
        public string damage { get; set; }
        public List<object> brandOrigin { get; set; }
        public List<object> excludeMM { get; set; }
        public List<object> state { get; set; }
        public List<object> city { get; set; }
        public List<object> auto_options { get; set; }
        public string target { get; set; }
        public string @event { get; set; }
        public int lang_id { get; set; }
        public List<object> m_state { get; set; }
        public List<object> m_city { get; set; }
        public List<object> marka { get; set; }
        public List<object> model { get; set; }
        public List<object> mm_marka { get; set; }
        public List<object> mm_model { get; set; }
        public List<object> mm_marka_filtr { get; set; }
        public List<object> mm_model_filtr { get; set; }
        public List<object> exchange_filter { get; set; }
        public List<object> mm_country { get; set; }
        public List<object> mm_country_exeption { get; set; }
        public List<object> currencies_arr { get; set; }
        public List<object> hide_black_list { get; set; }
        public List<object> body_id { get; set; }
        public List<object> bodyStyleId { get; set; }
        public int matched_country { get; set; }
        public List<object> bodystyle { get; set; }
    }

    public class SearchParams
    {
        public All all { get; set; }
        public Cleaned cleaned { get; set; }
    }

    public class Additional
    {
        public List<object> user_auto_positions { get; set; }
        public SearchParams search_params { get; set; }
        public string query_string { get; set; }
    }

    public class Result
    {
        public SearchResult search_result { get; set; }
        public ActiveMarka active_marka { get; set; }
        public ActiveModel active_model { get; set; }
        public object active_state { get; set; }
        public object active_city { get; set; }
        public object revies { get; set; }
        public Additional additional { get; set; }
    }

    public class SearchResults
    {
        public AdditionalParams additional_params { get; set; }
        public Result result { get; set; }
    }
}