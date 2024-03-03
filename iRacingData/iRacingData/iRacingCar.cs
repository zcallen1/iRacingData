using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace iRacingData
{
    [JsonUnmappedMemberHandling(JsonUnmappedMemberHandling.Disallow)]
    internal class iRacingCar
    {
        [JsonPropertyName("ai_enabled")]
        public bool AiEnabled { get; set; }

        [JsonPropertyName("allow_number_colors")]
        public bool AllowNumberColors { get; set; }
        [JsonPropertyName("allow_number_font")]
        public bool AllowNumberFont { get; set; }
        [JsonPropertyName("allow_sponsor1")]
        public bool AllowSponsor1 { get; set; }
        [JsonPropertyName("allow_sponsor2")]
        public bool AllowSponsor2 { get; set; }
        [JsonPropertyName("allow_wheel_color")]
        public bool AllowWheelColor { get; set; }
        [JsonPropertyName("award_exempt")]
        public bool AwardExempt { get; set; }
        [JsonPropertyName("car_dirpath")]
        public string CarDirpath { get; set; }
        [JsonPropertyName("car_id")]
        public int CarId { get; set; }
        [JsonPropertyName("car_name")]
        public string CarName { get; set; }
        [JsonPropertyName("car_name_abbreviated")]
        public string CarNameAbbreviated { get; set; }
        [JsonPropertyName("car_types")]
        public System.Text.Json.JsonElement CarTypes { get; set; }
        //public IReadOnlyList<iRacingCar> CarTypes { get; set; }
        [JsonPropertyName("car_weight")]
        public int CarWeight { get; set; }
        [JsonPropertyName("categories")]
        public IReadOnlyList<string> Categories { get; set; }
        [JsonPropertyName("created")]
        public DateTime Created { get; set; }
        [JsonPropertyName("first_sale")]
        public DateTime FirstSale { get; set; }
        [JsonPropertyName("forum_url")]
        public string ForumUrl { get; set; }
        [JsonPropertyName("free_with_subscription")]
        public bool FreeWithSubscription { get; set; }
        [JsonPropertyName("has_headlights")]
        public bool HasHeadLights { get; set; }
        [JsonPropertyName("has_multiple_dry_tire_types")]
        public bool HasMultipleDryTireTypes { get; set; }
        [JsonPropertyName("hp")]
        public int Hp { get; set; }
        [JsonPropertyName("is_ps_purchasable")]
        public bool IsPsPurchasable { get; set; }
        [JsonPropertyName("max_power_adjust_pct")]
        public int MaxPowerAdjustPct { get; set; }
        [JsonPropertyName("max_weight_penalty_kg")]
        public int MaxWeightPenaltyKg { get; set; }
        [JsonPropertyName("min_power_adjust_pct")]
        public int MinPowerAdjustPct { get; set; }
        [JsonPropertyName("package_id")]
        public int PackageId { get; set; }
        [JsonPropertyName("patterns")]
        public int Patterns { get; set; }
        [JsonPropertyName("price")]
        public double Price { get; set; }
        [JsonPropertyName("price_display")]
        public string PriceDisplay { get; set; }
        [JsonPropertyName("retired")]
        public bool Retired { get; set; }
        [JsonPropertyName("search_filters")]
        public string SearchFilters { get; set; }
        [JsonPropertyName("sku")]
        public int Sku { get; set; }
        // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);

    }
}
