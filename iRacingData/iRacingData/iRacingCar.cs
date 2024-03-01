using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace iRacingData
{
    internal class iRacingCar
    {
        // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
        public record iRacingCarRecord(
            [property: JsonPropertyName("car_type")] string CarType
        );

        public record Root(
            [property: JsonPropertyName("ai_enabled")] bool AiEnabled,
            [property: JsonPropertyName("allow_number_colors")] bool AllowNumberColors,
            [property: JsonPropertyName("allow_number_font")] bool AllowNumberFont,
            [property: JsonPropertyName("allow_sponsor1")] bool AllowSponsor1,
            [property: JsonPropertyName("allow_sponsor2")] bool AllowSponsor2,
            [property: JsonPropertyName("allow_wheel_color")] bool AllowWheelColor,
            [property: JsonPropertyName("award_exempt")] bool AwardExempt,
            [property: JsonPropertyName("car_dirpath")] string CarDirpath,
            [property: JsonPropertyName("car_id")] int CarId,
            [property: JsonPropertyName("car_name")] string CarName,
            [property: JsonPropertyName("car_name_abbreviated")] string CarNameAbbreviated,
            [property: JsonPropertyName("car_types")] IReadOnlyList<iRacingCar> CarTypes,
            [property: JsonPropertyName("car_weight")] int CarWeight,
            [property: JsonPropertyName("categories")] IReadOnlyList<string> Categories,
            [property: JsonPropertyName("created")] DateTime Created,
            [property: JsonPropertyName("first_sale")] DateTime FirstSale,
            [property: JsonPropertyName("forum_url")] string ForumUrl,
            [property: JsonPropertyName("free_with_subscription")] bool FreeWithSubscription,
            [property: JsonPropertyName("has_headlights")] bool HasHeadlights,
            [property: JsonPropertyName("has_multiple_dry_tire_types")] bool HasMultipleDryTireTypes,
            [property: JsonPropertyName("hp")] int Hp,
            [property: JsonPropertyName("is_ps_purchasable")] bool IsPsPurchasable,
            [property: JsonPropertyName("max_power_adjust_pct")] int MaxPowerAdjustPct,
            [property: JsonPropertyName("max_weight_penalty_kg")] int MaxWeightPenaltyKg,
            [property: JsonPropertyName("min_power_adjust_pct")] int MinPowerAdjustPct,
            [property: JsonPropertyName("package_id")] int PackageId,
            [property: JsonPropertyName("patterns")] int Patterns,
            [property: JsonPropertyName("price")] double Price,
            [property: JsonPropertyName("price_display")] string PriceDisplay,
            [property: JsonPropertyName("retired")] bool Retired,
            [property: JsonPropertyName("search_filters")] string SearchFilters,
            [property: JsonPropertyName("sku")] int Sku
        );


    }
}
