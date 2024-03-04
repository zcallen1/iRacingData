using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace iRacingData
{
    [JsonUnmappedMemberHandling(JsonUnmappedMemberHandling.Disallow)]
    internal class Track
    {
        [JsonPropertyName("ai_enabled")]
        public bool AiEnabled { get; init; }

        [JsonPropertyName("allow_pitlane_collisions")]
        public bool AllowPitlaneCollisions { get; init; }

        [JsonPropertyName("allow_rolling_start")]
        public bool AllowRollingStart { get; init; }

        [JsonPropertyName("allow_standing_start")]
        public bool AllowStandingStart { get; init; }

        [JsonPropertyName("award_exempt")]
        public bool AwardExempt { get; init; }

        [JsonPropertyName("category")]
        public string Category { get; init; }

        [JsonPropertyName("category_id")]
        public int CategoryId { get; init; }

        [JsonPropertyName("closes")]
        public string Closes { get; init; }

        [JsonPropertyName("config_name")]
        public string ConfigName { get; init; }

        [JsonPropertyName("corners_per_lap")]
        public int CornersPerLap { get; init; }

        [JsonPropertyName("created")]
        public DateTime Created { get; init; }

        [JsonPropertyName("first_sale")]
        public DateTime FirstSale { get; init; }

        [JsonPropertyName("free_with_subscription")]
        public bool FreeWithSubscription { get; init; }

        [JsonPropertyName("fully_lit")]
        public bool FullyLit { get; init; }

        [JsonPropertyName("grid_stalls")]
        public int GridStalls { get; init; }

        [JsonPropertyName("has_opt_path")]
        public bool HasOptPath { get; init; }

        [JsonPropertyName("has_short_parade_lap")]
        public bool HasShortParadeLap { get; init; }

        [JsonPropertyName("has_start_zone")]
        public bool HasStartZone { get; init; }

        [JsonPropertyName("has_svg_map")]
        public bool HasSvgMap { get; init; }

        [JsonPropertyName("is_dirt")]
        public bool IsDirt { get; init; }

        [JsonPropertyName("is_oval")]
        public bool IsOval { get; init; }

        [JsonPropertyName("is_ps_purchasable")]
        public bool IsPsPurchasable { get; init; }

        [JsonPropertyName("lap_scoring")]
        public int LapScoring { get; init; }

        [JsonPropertyName("latitude")]
        public double Latitude { get; init; }

        [JsonPropertyName("location")]
        public string Location { get; init; }

        [JsonPropertyName("longitude")]
        public double Longitude { get; init; }

        [JsonPropertyName("max_cars")]
        public int MaxCars { get; init; }

        [JsonPropertyName("night_lighting")]
        public bool NightLighting { get; init; }

        [JsonPropertyName("nominal_lap_time")]
        public double NominalLapTime { get; init; }

        [JsonPropertyName("number_pitstalls")]
        public int NumberPitstalls { get; init; }

        [JsonPropertyName("opens")]
        public string Opens { get; init; }

        [JsonPropertyName("package_id")]
        public int PackageId { get; init; }

        [JsonPropertyName("pit_road_speed_limit")]
        public int PitRoadSpeedLimit { get; init; }

        [JsonPropertyName("price")]
        public int Price { get; init; }

        [JsonPropertyName("price_display")]
        public string PriceDisplay { get; init; }

        [JsonPropertyName("priority")]
        public int Priority { get; init; }

        [JsonPropertyName("purchasable")]
        public bool Purchasable { get; init; }

        [JsonPropertyName("qualify_laps")]
        public int QualifyLaps { get; init; }

        [JsonPropertyName("restart_on_left")]
        public bool RestartOnLeft { get; init; }

        [JsonPropertyName("retired")]
        public bool Retired { get; init; }

        [JsonPropertyName("search_filters")]
        public string SearchFilters { get; init; }

        [JsonPropertyName("site_url")]
        public string SiteUrl { get; init; }

        [JsonPropertyName("sku")]
        public int Sku { get; init; }

        [JsonPropertyName("solo_laps")]
        public int SoloLaps { get; init; }

        [JsonPropertyName("start_on_left")]
        public bool StartOnLeft { get; init; }

        [JsonPropertyName("supports_grip_compound")]
        public bool SupportsGripCompound { get; init; }

        [JsonPropertyName("tech_track")]
        public bool TechTrack { get; init; }

        [JsonPropertyName("time_zone")]
        public string TimeZone { get; init; }

        [JsonPropertyName("track_config_length")]
        public double TrackConfigLength { get; init; }

        [JsonPropertyName("track_dirpath")]
        public string TrackDirpath { get; init; }

        [JsonPropertyName("track_id")]
        public int TrackId { get; init; }

        [JsonPropertyName("track_name")]
        public string TrackName { get; init; }

        [JsonPropertyName("track_types")]
        public System.Text.Json.JsonElement TrackTypes { get; init; }
        //public List<TrackType> TrackTypes { get; init; }
    }
}
