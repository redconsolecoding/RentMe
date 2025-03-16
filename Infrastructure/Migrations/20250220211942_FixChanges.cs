using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApartmentFeatures_Apartments_ApartmentId",
                table: "ApartmentFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_ApartmentFeatures_Features_FeatureId",
                table: "ApartmentFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_ApartmentGuests_Apartments_ApartmentId",
                table: "ApartmentGuests");

            migrationBuilder.DropForeignKey(
                name: "FK_ApartmentGuests_GuestType_GuestTypeId",
                table: "ApartmentGuests");

            migrationBuilder.DropForeignKey(
                name: "FK_ApartmentPhotos_Apartments_ApartmentId",
                table: "ApartmentPhotos");

            migrationBuilder.DropForeignKey(
                name: "FK_ApartmentPhotos_Photos_PhotoId",
                table: "ApartmentPhotos");

            migrationBuilder.DropForeignKey(
                name: "FK_ApartmentPrices_Apartments_ApartmentId",
                table: "ApartmentPrices");

            migrationBuilder.DropForeignKey(
                name: "FK_ApartmentReviews_Apartments_ApartmentId",
                table: "ApartmentReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_ApartmentReviews_Reviews_ReviewId",
                table: "ApartmentReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Apartments_Photos_PhotoId",
                table: "Apartments");

            migrationBuilder.DropForeignKey(
                name: "FK_Apartments_RoomTypes_RoomTypeId",
                table: "Apartments");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelFeatures_Features_FeatureId",
                table: "HotelFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelFeatures_Hotels_HotelId",
                table: "HotelFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelGuests_GuestType_GuestTypeId",
                table: "HotelGuests");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelGuests_Hotels_HotelId",
                table: "HotelGuests");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelPhotos_Hotels_HotelId",
                table: "HotelPhotos");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelPhotos_Photos_PhotoId",
                table: "HotelPhotos");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelPrices_Hotels_HotelId",
                table: "HotelPrices");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelReviews_Hotels_HotelId",
                table: "HotelReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelReviews_Reviews_ReviewId",
                table: "HotelReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelRooms_Hotels_HotelId",
                table: "HotelRooms");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelRooms_RoomTypes_RoomTypeId",
                table: "HotelRooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Hotels_Photos_PhotoId",
                table: "Hotels");

            migrationBuilder.DropForeignKey(
                name: "FK_Hotels_RoomTypes_RoomTypeId",
                table: "Hotels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Services",
                table: "Services");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoomTypes",
                table: "RoomTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Photos",
                table: "Photos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hotels",
                table: "Hotels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelRooms",
                table: "HotelRooms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelReviews",
                table: "HotelReviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelPrices",
                table: "HotelPrices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelPhotos",
                table: "HotelPhotos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelGuests",
                table: "HotelGuests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelFeatures",
                table: "HotelFeatures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Features",
                table: "Features");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Apartments",
                table: "Apartments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApartmentReviews",
                table: "ApartmentReviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApartmentPrices",
                table: "ApartmentPrices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApartmentPhotos",
                table: "ApartmentPhotos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApartmentGuests",
                table: "ApartmentGuests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApartmentFeatures",
                table: "ApartmentFeatures");

            migrationBuilder.RenameTable(
                name: "Services",
                newName: "Service");

            migrationBuilder.RenameTable(
                name: "RoomTypes",
                newName: "RoomType");

            migrationBuilder.RenameTable(
                name: "Reviews",
                newName: "Review");

            migrationBuilder.RenameTable(
                name: "Photos",
                newName: "Photo");

            migrationBuilder.RenameTable(
                name: "Hotels",
                newName: "Hotel");

            migrationBuilder.RenameTable(
                name: "HotelRooms",
                newName: "HotelRoom");

            migrationBuilder.RenameTable(
                name: "HotelReviews",
                newName: "HotelReview");

            migrationBuilder.RenameTable(
                name: "HotelPrices",
                newName: "HotelPrice");

            migrationBuilder.RenameTable(
                name: "HotelPhotos",
                newName: "HotelPhoto");

            migrationBuilder.RenameTable(
                name: "HotelGuests",
                newName: "HotelGuest");

            migrationBuilder.RenameTable(
                name: "HotelFeatures",
                newName: "HotelFeature");

            migrationBuilder.RenameTable(
                name: "Features",
                newName: "Feature");

            migrationBuilder.RenameTable(
                name: "Apartments",
                newName: "Apartment");

            migrationBuilder.RenameTable(
                name: "ApartmentReviews",
                newName: "ApartmentReview");

            migrationBuilder.RenameTable(
                name: "ApartmentPrices",
                newName: "ApartmentPrice");

            migrationBuilder.RenameTable(
                name: "ApartmentPhotos",
                newName: "ApartmentPhoto");

            migrationBuilder.RenameTable(
                name: "ApartmentGuests",
                newName: "ApartmentGuest");

            migrationBuilder.RenameTable(
                name: "ApartmentFeatures",
                newName: "ApartmentFeature");

            migrationBuilder.RenameIndex(
                name: "IX_Hotels_RoomTypeId",
                table: "Hotel",
                newName: "IX_Hotel_RoomTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Hotels_PhotoId",
                table: "Hotel",
                newName: "IX_Hotel_PhotoId");

            migrationBuilder.RenameIndex(
                name: "IX_HotelRooms_RoomTypeId",
                table: "HotelRoom",
                newName: "IX_HotelRoom_RoomTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_HotelRooms_HotelId",
                table: "HotelRoom",
                newName: "IX_HotelRoom_HotelId");

            migrationBuilder.RenameIndex(
                name: "IX_HotelReviews_ReviewId",
                table: "HotelReview",
                newName: "IX_HotelReview_ReviewId");

            migrationBuilder.RenameIndex(
                name: "IX_HotelPrices_HotelId",
                table: "HotelPrice",
                newName: "IX_HotelPrice_HotelId");

            migrationBuilder.RenameIndex(
                name: "IX_HotelPhotos_PhotoId",
                table: "HotelPhoto",
                newName: "IX_HotelPhoto_PhotoId");

            migrationBuilder.RenameIndex(
                name: "IX_HotelGuests_HotelId",
                table: "HotelGuest",
                newName: "IX_HotelGuest_HotelId");

            migrationBuilder.RenameIndex(
                name: "IX_HotelGuests_GuestTypeId",
                table: "HotelGuest",
                newName: "IX_HotelGuest_GuestTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_HotelFeatures_FeatureId",
                table: "HotelFeature",
                newName: "IX_HotelFeature_FeatureId");

            migrationBuilder.RenameIndex(
                name: "IX_Apartments_RoomTypeId",
                table: "Apartment",
                newName: "IX_Apartment_RoomTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Apartments_PhotoId",
                table: "Apartment",
                newName: "IX_Apartment_PhotoId");

            migrationBuilder.RenameIndex(
                name: "IX_ApartmentReviews_ApartmentId",
                table: "ApartmentReview",
                newName: "IX_ApartmentReview_ApartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_ApartmentPrices_ApartmentId",
                table: "ApartmentPrice",
                newName: "IX_ApartmentPrice_ApartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_ApartmentPhotos_ApartmentId",
                table: "ApartmentPhoto",
                newName: "IX_ApartmentPhoto_ApartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_ApartmentGuests_GuestTypeId",
                table: "ApartmentGuest",
                newName: "IX_ApartmentGuest_GuestTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_ApartmentGuests_ApartmentId",
                table: "ApartmentGuest",
                newName: "IX_ApartmentGuest_ApartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_ApartmentFeatures_FeatureId",
                table: "ApartmentFeature",
                newName: "IX_ApartmentFeature_FeatureId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Service",
                table: "Service",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoomType",
                table: "RoomType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Review",
                table: "Review",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Photo",
                table: "Photo",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hotel",
                table: "Hotel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelRoom",
                table: "HotelRoom",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelReview",
                table: "HotelReview",
                columns: new[] { "HotelId", "ReviewId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelPrice",
                table: "HotelPrice",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelPhoto",
                table: "HotelPhoto",
                columns: new[] { "HotelId", "PhotoId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelGuest",
                table: "HotelGuest",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelFeature",
                table: "HotelFeature",
                columns: new[] { "HotelId", "FeatureId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Feature",
                table: "Feature",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Apartment",
                table: "Apartment",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApartmentReview",
                table: "ApartmentReview",
                columns: new[] { "ReviewId", "ApartmentId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApartmentPrice",
                table: "ApartmentPrice",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApartmentPhoto",
                table: "ApartmentPhoto",
                columns: new[] { "PhotoId", "ApartmentId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApartmentGuest",
                table: "ApartmentGuest",
                columns: new[] { "GuestId", "ApartmentId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApartmentFeature",
                table: "ApartmentFeature",
                columns: new[] { "ApartmentId", "FeatureId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Apartment_Photo_PhotoId",
                table: "Apartment",
                column: "PhotoId",
                principalTable: "Photo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Apartment_RoomType_RoomTypeId",
                table: "Apartment",
                column: "RoomTypeId",
                principalTable: "RoomType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApartmentFeature_Apartment_ApartmentId",
                table: "ApartmentFeature",
                column: "ApartmentId",
                principalTable: "Apartment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApartmentFeature_Feature_FeatureId",
                table: "ApartmentFeature",
                column: "FeatureId",
                principalTable: "Feature",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApartmentGuest_Apartment_ApartmentId",
                table: "ApartmentGuest",
                column: "ApartmentId",
                principalTable: "Apartment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApartmentGuest_GuestType_GuestTypeId",
                table: "ApartmentGuest",
                column: "GuestTypeId",
                principalTable: "GuestType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApartmentPhoto_Apartment_ApartmentId",
                table: "ApartmentPhoto",
                column: "ApartmentId",
                principalTable: "Apartment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApartmentPhoto_Photo_PhotoId",
                table: "ApartmentPhoto",
                column: "PhotoId",
                principalTable: "Photo",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApartmentPrice_Apartment_ApartmentId",
                table: "ApartmentPrice",
                column: "ApartmentId",
                principalTable: "Apartment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApartmentReview_Apartment_ApartmentId",
                table: "ApartmentReview",
                column: "ApartmentId",
                principalTable: "Apartment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApartmentReview_Review_ReviewId",
                table: "ApartmentReview",
                column: "ReviewId",
                principalTable: "Review",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hotel_Photo_PhotoId",
                table: "Hotel",
                column: "PhotoId",
                principalTable: "Photo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hotel_RoomType_RoomTypeId",
                table: "Hotel",
                column: "RoomTypeId",
                principalTable: "RoomType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelFeature_Feature_FeatureId",
                table: "HotelFeature",
                column: "FeatureId",
                principalTable: "Feature",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelFeature_Hotel_HotelId",
                table: "HotelFeature",
                column: "HotelId",
                principalTable: "Hotel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelGuest_GuestType_GuestTypeId",
                table: "HotelGuest",
                column: "GuestTypeId",
                principalTable: "GuestType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelGuest_Hotel_HotelId",
                table: "HotelGuest",
                column: "HotelId",
                principalTable: "Hotel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelPhoto_Hotel_HotelId",
                table: "HotelPhoto",
                column: "HotelId",
                principalTable: "Hotel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelPhoto_Photo_PhotoId",
                table: "HotelPhoto",
                column: "PhotoId",
                principalTable: "Photo",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HotelPrice_Hotel_HotelId",
                table: "HotelPrice",
                column: "HotelId",
                principalTable: "Hotel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelReview_Hotel_HotelId",
                table: "HotelReview",
                column: "HotelId",
                principalTable: "Hotel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelReview_Review_ReviewId",
                table: "HotelReview",
                column: "ReviewId",
                principalTable: "Review",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelRoom_Hotel_HotelId",
                table: "HotelRoom",
                column: "HotelId",
                principalTable: "Hotel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelRoom_RoomType_RoomTypeId",
                table: "HotelRoom",
                column: "RoomTypeId",
                principalTable: "RoomType",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apartment_Photo_PhotoId",
                table: "Apartment");

            migrationBuilder.DropForeignKey(
                name: "FK_Apartment_RoomType_RoomTypeId",
                table: "Apartment");

            migrationBuilder.DropForeignKey(
                name: "FK_ApartmentFeature_Apartment_ApartmentId",
                table: "ApartmentFeature");

            migrationBuilder.DropForeignKey(
                name: "FK_ApartmentFeature_Feature_FeatureId",
                table: "ApartmentFeature");

            migrationBuilder.DropForeignKey(
                name: "FK_ApartmentGuest_Apartment_ApartmentId",
                table: "ApartmentGuest");

            migrationBuilder.DropForeignKey(
                name: "FK_ApartmentGuest_GuestType_GuestTypeId",
                table: "ApartmentGuest");

            migrationBuilder.DropForeignKey(
                name: "FK_ApartmentPhoto_Apartment_ApartmentId",
                table: "ApartmentPhoto");

            migrationBuilder.DropForeignKey(
                name: "FK_ApartmentPhoto_Photo_PhotoId",
                table: "ApartmentPhoto");

            migrationBuilder.DropForeignKey(
                name: "FK_ApartmentPrice_Apartment_ApartmentId",
                table: "ApartmentPrice");

            migrationBuilder.DropForeignKey(
                name: "FK_ApartmentReview_Apartment_ApartmentId",
                table: "ApartmentReview");

            migrationBuilder.DropForeignKey(
                name: "FK_ApartmentReview_Review_ReviewId",
                table: "ApartmentReview");

            migrationBuilder.DropForeignKey(
                name: "FK_Hotel_Photo_PhotoId",
                table: "Hotel");

            migrationBuilder.DropForeignKey(
                name: "FK_Hotel_RoomType_RoomTypeId",
                table: "Hotel");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelFeature_Feature_FeatureId",
                table: "HotelFeature");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelFeature_Hotel_HotelId",
                table: "HotelFeature");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelGuest_GuestType_GuestTypeId",
                table: "HotelGuest");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelGuest_Hotel_HotelId",
                table: "HotelGuest");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelPhoto_Hotel_HotelId",
                table: "HotelPhoto");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelPhoto_Photo_PhotoId",
                table: "HotelPhoto");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelPrice_Hotel_HotelId",
                table: "HotelPrice");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelReview_Hotel_HotelId",
                table: "HotelReview");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelReview_Review_ReviewId",
                table: "HotelReview");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelRoom_Hotel_HotelId",
                table: "HotelRoom");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelRoom_RoomType_RoomTypeId",
                table: "HotelRoom");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Service",
                table: "Service");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoomType",
                table: "RoomType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Review",
                table: "Review");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Photo",
                table: "Photo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelRoom",
                table: "HotelRoom");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelReview",
                table: "HotelReview");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelPrice",
                table: "HotelPrice");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelPhoto",
                table: "HotelPhoto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelGuest",
                table: "HotelGuest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelFeature",
                table: "HotelFeature");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hotel",
                table: "Hotel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Feature",
                table: "Feature");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApartmentReview",
                table: "ApartmentReview");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApartmentPrice",
                table: "ApartmentPrice");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApartmentPhoto",
                table: "ApartmentPhoto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApartmentGuest",
                table: "ApartmentGuest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApartmentFeature",
                table: "ApartmentFeature");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Apartment",
                table: "Apartment");

            migrationBuilder.RenameTable(
                name: "Service",
                newName: "Services");

            migrationBuilder.RenameTable(
                name: "RoomType",
                newName: "RoomTypes");

            migrationBuilder.RenameTable(
                name: "Review",
                newName: "Reviews");

            migrationBuilder.RenameTable(
                name: "Photo",
                newName: "Photos");

            migrationBuilder.RenameTable(
                name: "HotelRoom",
                newName: "HotelRooms");

            migrationBuilder.RenameTable(
                name: "HotelReview",
                newName: "HotelReviews");

            migrationBuilder.RenameTable(
                name: "HotelPrice",
                newName: "HotelPrices");

            migrationBuilder.RenameTable(
                name: "HotelPhoto",
                newName: "HotelPhotos");

            migrationBuilder.RenameTable(
                name: "HotelGuest",
                newName: "HotelGuests");

            migrationBuilder.RenameTable(
                name: "HotelFeature",
                newName: "HotelFeatures");

            migrationBuilder.RenameTable(
                name: "Hotel",
                newName: "Hotels");

            migrationBuilder.RenameTable(
                name: "Feature",
                newName: "Features");

            migrationBuilder.RenameTable(
                name: "ApartmentReview",
                newName: "ApartmentReviews");

            migrationBuilder.RenameTable(
                name: "ApartmentPrice",
                newName: "ApartmentPrices");

            migrationBuilder.RenameTable(
                name: "ApartmentPhoto",
                newName: "ApartmentPhotos");

            migrationBuilder.RenameTable(
                name: "ApartmentGuest",
                newName: "ApartmentGuests");

            migrationBuilder.RenameTable(
                name: "ApartmentFeature",
                newName: "ApartmentFeatures");

            migrationBuilder.RenameTable(
                name: "Apartment",
                newName: "Apartments");

            migrationBuilder.RenameIndex(
                name: "IX_HotelRoom_RoomTypeId",
                table: "HotelRooms",
                newName: "IX_HotelRooms_RoomTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_HotelRoom_HotelId",
                table: "HotelRooms",
                newName: "IX_HotelRooms_HotelId");

            migrationBuilder.RenameIndex(
                name: "IX_HotelReview_ReviewId",
                table: "HotelReviews",
                newName: "IX_HotelReviews_ReviewId");

            migrationBuilder.RenameIndex(
                name: "IX_HotelPrice_HotelId",
                table: "HotelPrices",
                newName: "IX_HotelPrices_HotelId");

            migrationBuilder.RenameIndex(
                name: "IX_HotelPhoto_PhotoId",
                table: "HotelPhotos",
                newName: "IX_HotelPhotos_PhotoId");

            migrationBuilder.RenameIndex(
                name: "IX_HotelGuest_HotelId",
                table: "HotelGuests",
                newName: "IX_HotelGuests_HotelId");

            migrationBuilder.RenameIndex(
                name: "IX_HotelGuest_GuestTypeId",
                table: "HotelGuests",
                newName: "IX_HotelGuests_GuestTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_HotelFeature_FeatureId",
                table: "HotelFeatures",
                newName: "IX_HotelFeatures_FeatureId");

            migrationBuilder.RenameIndex(
                name: "IX_Hotel_RoomTypeId",
                table: "Hotels",
                newName: "IX_Hotels_RoomTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Hotel_PhotoId",
                table: "Hotels",
                newName: "IX_Hotels_PhotoId");

            migrationBuilder.RenameIndex(
                name: "IX_ApartmentReview_ApartmentId",
                table: "ApartmentReviews",
                newName: "IX_ApartmentReviews_ApartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_ApartmentPrice_ApartmentId",
                table: "ApartmentPrices",
                newName: "IX_ApartmentPrices_ApartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_ApartmentPhoto_ApartmentId",
                table: "ApartmentPhotos",
                newName: "IX_ApartmentPhotos_ApartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_ApartmentGuest_GuestTypeId",
                table: "ApartmentGuests",
                newName: "IX_ApartmentGuests_GuestTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_ApartmentGuest_ApartmentId",
                table: "ApartmentGuests",
                newName: "IX_ApartmentGuests_ApartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_ApartmentFeature_FeatureId",
                table: "ApartmentFeatures",
                newName: "IX_ApartmentFeatures_FeatureId");

            migrationBuilder.RenameIndex(
                name: "IX_Apartment_RoomTypeId",
                table: "Apartments",
                newName: "IX_Apartments_RoomTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Apartment_PhotoId",
                table: "Apartments",
                newName: "IX_Apartments_PhotoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Services",
                table: "Services",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoomTypes",
                table: "RoomTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Photos",
                table: "Photos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelRooms",
                table: "HotelRooms",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelReviews",
                table: "HotelReviews",
                columns: new[] { "HotelId", "ReviewId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelPrices",
                table: "HotelPrices",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelPhotos",
                table: "HotelPhotos",
                columns: new[] { "HotelId", "PhotoId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelGuests",
                table: "HotelGuests",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelFeatures",
                table: "HotelFeatures",
                columns: new[] { "HotelId", "FeatureId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hotels",
                table: "Hotels",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Features",
                table: "Features",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApartmentReviews",
                table: "ApartmentReviews",
                columns: new[] { "ReviewId", "ApartmentId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApartmentPrices",
                table: "ApartmentPrices",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApartmentPhotos",
                table: "ApartmentPhotos",
                columns: new[] { "PhotoId", "ApartmentId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApartmentGuests",
                table: "ApartmentGuests",
                columns: new[] { "GuestId", "ApartmentId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApartmentFeatures",
                table: "ApartmentFeatures",
                columns: new[] { "ApartmentId", "FeatureId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Apartments",
                table: "Apartments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApartmentFeatures_Apartments_ApartmentId",
                table: "ApartmentFeatures",
                column: "ApartmentId",
                principalTable: "Apartments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApartmentFeatures_Features_FeatureId",
                table: "ApartmentFeatures",
                column: "FeatureId",
                principalTable: "Features",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApartmentGuests_Apartments_ApartmentId",
                table: "ApartmentGuests",
                column: "ApartmentId",
                principalTable: "Apartments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApartmentGuests_GuestType_GuestTypeId",
                table: "ApartmentGuests",
                column: "GuestTypeId",
                principalTable: "GuestType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApartmentPhotos_Apartments_ApartmentId",
                table: "ApartmentPhotos",
                column: "ApartmentId",
                principalTable: "Apartments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApartmentPhotos_Photos_PhotoId",
                table: "ApartmentPhotos",
                column: "PhotoId",
                principalTable: "Photos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApartmentPrices_Apartments_ApartmentId",
                table: "ApartmentPrices",
                column: "ApartmentId",
                principalTable: "Apartments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApartmentReviews_Apartments_ApartmentId",
                table: "ApartmentReviews",
                column: "ApartmentId",
                principalTable: "Apartments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApartmentReviews_Reviews_ReviewId",
                table: "ApartmentReviews",
                column: "ReviewId",
                principalTable: "Reviews",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Apartments_Photos_PhotoId",
                table: "Apartments",
                column: "PhotoId",
                principalTable: "Photos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Apartments_RoomTypes_RoomTypeId",
                table: "Apartments",
                column: "RoomTypeId",
                principalTable: "RoomTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HotelFeatures_Features_FeatureId",
                table: "HotelFeatures",
                column: "FeatureId",
                principalTable: "Features",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelFeatures_Hotels_HotelId",
                table: "HotelFeatures",
                column: "HotelId",
                principalTable: "Hotels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelGuests_GuestType_GuestTypeId",
                table: "HotelGuests",
                column: "GuestTypeId",
                principalTable: "GuestType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelGuests_Hotels_HotelId",
                table: "HotelGuests",
                column: "HotelId",
                principalTable: "Hotels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelPhotos_Hotels_HotelId",
                table: "HotelPhotos",
                column: "HotelId",
                principalTable: "Hotels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelPhotos_Photos_PhotoId",
                table: "HotelPhotos",
                column: "PhotoId",
                principalTable: "Photos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HotelPrices_Hotels_HotelId",
                table: "HotelPrices",
                column: "HotelId",
                principalTable: "Hotels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelReviews_Hotels_HotelId",
                table: "HotelReviews",
                column: "HotelId",
                principalTable: "Hotels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelReviews_Reviews_ReviewId",
                table: "HotelReviews",
                column: "ReviewId",
                principalTable: "Reviews",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelRooms_Hotels_HotelId",
                table: "HotelRooms",
                column: "HotelId",
                principalTable: "Hotels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelRooms_RoomTypes_RoomTypeId",
                table: "HotelRooms",
                column: "RoomTypeId",
                principalTable: "RoomTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Hotels_Photos_PhotoId",
                table: "Hotels",
                column: "PhotoId",
                principalTable: "Photos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hotels_RoomTypes_RoomTypeId",
                table: "Hotels",
                column: "RoomTypeId",
                principalTable: "RoomTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
