using System.Collections.Generic;
using System.Net.NetworkInformation;
using OrderKingCoreDemo.DAL.DataObjects;

namespace MyWasteDriver.DAL.DataObjects {
	public class PointsDataObject {
		public List<AllOrders> Orders { get; set; }
		public UnloadingPlaceObject UnloadingPlace { get; set; }
	}

	public class AllOrders {
		public string OrderId { get; set; }
		public string OrganizationName { get; set; }
		public string OrderAdress { get; set; }
		public PositionObject Coordinates { get; set; }
		public bool CompletedOrNot { get; set; }
		public string VisitingMode { get; set; }
		public string TravelIntructions { get; set; }
		public List<ContactInformation> CommunicationPhones { get; set; }
		public List<ImageUrl> AllImageUrl { get; set; }
	}
	public class ImageUrl { public string Url { get; set; } };

	public class ContactInformation {
		public string JobTitle { get; set; }
		public string FullName { get; set; }
		public string PhoneNumber { get; set; }
	}

	public class UnloadingPlaceObject
	{
		public string UnloadingAddress { get; set; }
		public string CompanyName { get; set; }
		public PositionObject Coordinates { get; set; }

	}
}

