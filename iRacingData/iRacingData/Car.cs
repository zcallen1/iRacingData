using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace iRacingData
{
    //[JsonUnmappedMemberHandling(JsonUnmappedMemberHandling.Disallow)]
    internal class Car
    {
        [JsonPropertyName("ai_enabled")]
        public bool AiEnabled { get; init; }
        [JsonPropertyName("allow_number_colors")]
        public bool AllowNumberColors { get; init; }
        [JsonPropertyName("allow_number_font")]
        public bool AllowNumberFont { get; init; }
        [JsonPropertyName("allow_sponsor1")]
        public bool AllowSponsor1 { get; init; }
        [JsonPropertyName("allow_sponsor2")]
        public bool AllowSponsor2 { get; init; }
        [JsonPropertyName("allow_wheel_color")]
        public bool AllowWheelColor { get; init; }
        [JsonPropertyName("award_exempt")]
        public bool AwardExempt { get; init; }
        [JsonPropertyName("car_dirpath")]
        public string CarDirpath { get; init; }
        [JsonPropertyName("car_id")]
        public int CarId { get; init; }
        [JsonPropertyName("car_name")]
        public string CarName { get; init; }
        [JsonPropertyName("car_name_abbreviated")]
        public string CarNameAbbreviated { get; init; }
        [JsonPropertyName("car_types")]
        public System.Text.Json.JsonElement CarTypes { get; init; }
        //public IReadOnlyList<iRacingCar> CarTypes { get; init; }
        [JsonPropertyName("car_weight")]
        public int CarWeight { get; init; }
        [JsonPropertyName("categories")]
        public IReadOnlyList<string> Categories { get; init; }
        [JsonPropertyName("created")]
        public DateTime Created { get; init; }
        [JsonPropertyName("first_sale")]
        public DateTime FirstSale { get; init; }
        [JsonPropertyName("forum_url")]
        public string ForumUrl { get; init; }
        [JsonPropertyName("free_with_subscription")]
        public bool FreeWithSubscription { get; init; }
        [JsonPropertyName("has_headlights")]
        public bool HasHeadLights { get; init; }
        [JsonPropertyName("has_multiple_dry_tire_types")]
        public bool HasMultipleDryTireTypes { get; init; }
        [JsonPropertyName("hp")]
        public int Hp { get; init; }
        [JsonPropertyName("is_ps_purchasable")]
        public bool IsPsPurchasable { get; init; }
        [JsonPropertyName("max_power_adjust_pct")]
        public int MaxPowerAdjustPct { get; init; }
        [JsonPropertyName("max_weight_penalty_kg")]
        public int MaxWeightPenaltyKg { get; init; }
        [JsonPropertyName("min_power_adjust_pct")]
        public int MinPowerAdjustPct { get; init; }
        [JsonPropertyName("package_id")]
        public int PackageId { get; init; }
        [JsonPropertyName("patterns")]
        public int Patterns { get; init; }
        [JsonPropertyName("price")]
        public double Price { get; init; }
        [JsonPropertyName("price_display")]
        public string PriceDisplay { get; init; }
        [JsonPropertyName("retired")]
        public bool Retired { get; init; }
        [JsonPropertyName("search_filters")]
        public string SearchFilters { get; init; }
        [JsonPropertyName("sku")]
        public int Sku { get; init; }
    }
}
