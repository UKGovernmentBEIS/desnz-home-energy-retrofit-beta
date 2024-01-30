using HerPublicWebsite.BusinessLogic.Models;
using HerPublicWebsite.BusinessLogic.Models.Enums;

namespace HerPublicWebsite.Data.Seeds;

public class LocalAuthoritySeedData {
  public static List<LocalAuthority> Data = new()
  {
    new()
    {
      CustodianCode = "9052", Name = "Aberdeenshire Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.aberdeenshire.gov.uk/",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "3805", Name = "Adur District Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//www.adur-worthing.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0031"
    },
    new()
    {
      CustodianCode = "1005", Name = "Amber Valley Borough Council", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//www.ambervalley.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "9053", Name = "Angus Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.angus.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "9054", Name = "Argyll and Bute Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.argyll-bute.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "3810", Name = "Arun District Council", Status = Hug2Status.Live, WebsiteUrl = "http=//www.arun.gov.uk/",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = "C_0031"
    },
    new()
    {
      CustodianCode = "3005", Name = "Ashfield District Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.ashfield.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "2205", Name = "Ashford Borough Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.ashford.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0007"
    },
    new()
    {
      CustodianCode = "3505", Name = "Babergh District Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//www.babergh.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0038"
    },
    new()
    {
      CustodianCode = "5060", Name = "London Borough of Barking and Dagenham", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.lbbd.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0017"
    },
    new()
    {
      CustodianCode = "5090", Name = "London Borough of Barnet", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.barnet.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0017"
    },
    new()
    {
      CustodianCode = "4405", Name = "Barnsley Metropolitan Borough Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.barnsley.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "1505", Name = "Basildon Borough Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.basildon.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0007"
    },
    new()
    {
      CustodianCode = "1705", Name = "Basingstoke and Deane Borough Council", Status = Hug2Status.Live,
      WebsiteUrl = "http=//www.basingstoke.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0031"
    },
    new()
    {
      CustodianCode = "3010", Name = "Bassetlaw District Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.bassetlaw.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "114", Name = "Bath and North East Somerset Council", Status = Hug2Status.Live,
      WebsiteUrl = "http=//www.bathnes.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0003"
    },
    new()
    {
      CustodianCode = "235", Name = "Bedford Borough Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.bedford.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0007"
    },
    new()
    {
      CustodianCode = "5120", Name = "London Borough of Bexley", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.bexley.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0017"
    },
    new()
    {
      CustodianCode = "4605", Name = "Birmingham City Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.birmingham.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "2405", Name = "Blaby District Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.blaby.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "2372", Name = "Blackburn with Darwen Borough Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//www.blackburn.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0002"
    },
    new()
    {
      CustodianCode = "2373", Name = "Blackpool Borough Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//www.blackpool.gov.uk/Home.aspx",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = "C_0002"
    },
    new()
    {
      CustodianCode = "6910", Name = "Blaenau Gwent County Borough Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.blaenau-gwent.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "1010", Name = "Bolsover District Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.bolsover.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "4205", Name = "Bolton Metropolitan Borough Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "http=//www.bolton.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "2505", Name = "Boston Borough Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.boston.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "1260", Name = "Bournemouth, Christchurch and Poole Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//www.bcpcouncil.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0015"
    },
    new()
    {
      CustodianCode = "335", Name = "Bracknell Forest Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.bracknell-forest.gov.uk/",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = "C_0007"
    },
    new()
    {
      CustodianCode = "4705", Name = "City of Bradford Metropolitan District Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.bradford.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "1510", Name = "Braintree District Council", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//www.braintree.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0007"
    },
    new()
    {
      CustodianCode = "2605", Name = "Breckland Council", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//www.breckland.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0004"
    },
    new()
    {
      CustodianCode = "5150", Name = "London Borough of Brent", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.brent.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0017"
    },
    new()
    {
      CustodianCode = "1515", Name = "Brentwood Borough Council", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//www.brentwood.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0007"
    },
    new()
    {
      CustodianCode = "6915", Name = "Bridgend County Borough Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.bridgend.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "1445", Name = "Brighton and Hove City Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//www.brighton-hove.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0031"
    },
    new()
    {
      CustodianCode = "116", Name = "Bristol City Council", Status = Hug2Status.Live, WebsiteUrl = "https=//www.bristol.gov.uk/",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = "C_0003"
    },
    new()
    {
      CustodianCode = "2610", Name = "Broadland District Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.southnorfolkandbroadland.gov.uk/",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = "C_0004"
    },
    new()
    {
      CustodianCode = "1805", Name = "Bromsgrove District Council", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//www.bromsgrove.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "1905", Name = "Borough of Broxbourne", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.broxbourne.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0007"
    },
    new()
    {
      CustodianCode = "3015", Name = "Broxtowe Borough Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.broxtowe.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "440", Name = "Buckinghamshire Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.buckinghamshire.gov.uk/",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = "C_0007"
    },
    new()
    {
      CustodianCode = "2315", Name = "Burnley Borough Council", Status = Hug2Status.Live,
      WebsiteUrl = "http=//www.burnley.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0002"
    },
    new()
    {
      CustodianCode = "4210", Name = "Bury Metropolitan Borough Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.bury.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "6920", Name = "Caerphilly County Borough Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "http=//www.caerphilly.gov.uk", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "4710", Name = "Calderdale Metropolitan Borough Council", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//www.calderdale.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "505", Name = "Cambridge City Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//www.cambridge.gov.uk/", IncomeThreshold = IncomeThreshold._34500,
      ConsortiumCode = "C_0006"
    },
    new()
    {
      CustodianCode = "5210", Name = "London Borough of Camden", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.camden.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0017"
    },
    new()
    {
      CustodianCode = "3405", Name = "Cannock Chase District Council", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//www.cannockchasedc.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "2210", Name = "Canterbury City Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.canterbury.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0007"
    },
    new()
    {
      CustodianCode = "6815", Name = "City of Cardiff Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.cardiff.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "6825", Name = "Carmarthenshire County Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.carmarthenshire.gov.wales/home/council-services/",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "1520", Name = "Castle Point Borough Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.castlepoint.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0007"
    },
    new()
    {
      CustodianCode = "240", Name = "Central Bedfordshire Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "http=//www.centralbedfordshire.gov.uk",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = "C_0007"
    },
    new()
    {
      CustodianCode = "6820", Name = "Ceredigion County Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "http=//www.ceredigion.gov.uk", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "2410", Name = "Charnwood Borough Council", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//www.charnwood.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "1525", Name = "Chelmsford City Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.chelmsford.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0007"
    },
    new()
    {
      CustodianCode = "1605", Name = "Cheltenham Borough Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//www.cheltenham.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0037"
    },
    new()
    {
      CustodianCode = "3105", Name = "Cherwell District Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//www.cherwell.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0029"
    },
    new()
    {
      CustodianCode = "660", Name = "Cheshire East Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.cheshireeast.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0008"
    },
    new()
    {
      CustodianCode = "665", Name = "Cheshire West and Chester Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.cheshirewestandchester.gov.uk/",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = "C_0008"
    },
    new()
    {
      CustodianCode = "1015", Name = "Chesterfield Borough Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.chesterfield.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "3815", Name = "Chichester District Council", Status = Hug2Status.Live,
      WebsiteUrl = "http=//www.chichester.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0031"
    },
    new()
    {
      CustodianCode = "2320", Name = "Chorley Council", Status = Hug2Status.Live, WebsiteUrl = "http=//www.chorley.gov.uk/",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = "C_0002"
    },
    new()
    {
      CustodianCode = "9051", Name = "Aberdeen City Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.aberdeencity.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "9059", Name = "Dundee City Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.dundeecity.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "9064", Name = "City of Edinburgh Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.edinburgh.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "9067", Name = "Glasgow City Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.glasgow.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "5030", Name = "City of London Corporation", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.cityoflondon.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0017"
    },
    new()
    {
      CustodianCode = "3455", Name = "Stoke-on-Trent City Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.stoke.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "5990", Name = "City of Westminster", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.westminster.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0017"
    },
    new()
    {
      CustodianCode = "9056", Name = "Clackmannanshire Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.clacks.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "1530", Name = "Colchester Borough Council", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//www.colchester.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0007"
    },
    new()
    {
      CustodianCode = "6905", Name = "Conwy County Borough Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.conwy.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "840", Name = "Cornwall Council", Status = Hug2Status.Live, WebsiteUrl = "https=//www.cornwall.gov.uk/",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = "C_0010"
    },
    new()
    {
      CustodianCode = "1610", Name = "Cotswold District Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//www.cotswold.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0037"
    },
    new()
    {
      CustodianCode = "4610", Name = "Coventry City Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.coventry.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "3820", Name = "Crawley Borough Council", Status = Hug2Status.Live, WebsiteUrl = "https=//crawley.gov.uk/",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = "C_0031"
    },
    new()
    {
      CustodianCode = "5240", Name = "London Borough of Croydon", Status = Hug2Status.Live,
      WebsiteUrl = "http=//www.croydon.gov.uk", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0017"
    },
    new()
    {
      CustodianCode = "940", Name = "Cumberland Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.cumberland.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0016"
    },
    new()
    {
      CustodianCode = "1910", Name = "Dacorum Borough Council", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//www.dacorum.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0007"
    },
    new()
    {
      CustodianCode = "1350", Name = "Darlington Borough Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.darlington.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0012"
    },
    new()
    {
      CustodianCode = "2215", Name = "Dartford Borough Council", Status = Hug2Status.Live,
      WebsiteUrl = "http=//www.dartford.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0013"
    },
    new()
    {
      CustodianCode = "6830", Name = "Denbighshire County Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.denbighshire.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "1055", Name = "Derby City", Status = Hug2Status.Pending, WebsiteUrl = "https=//www.derby.gov.uk/",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "1045", Name = "Derbyshire Dales District Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.derbyshiredales.gov.uk/",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "4410", Name = "Doncaster Metropolitan Borough Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "http=//www.doncaster.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "1265", Name = "Dorset Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//www.dorsetcouncil.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0015"
    },
    new()
    {
      CustodianCode = "2220", Name = "Dover District Council", Status = Hug2Status.Live, WebsiteUrl = "http=//www.dover.gov.uk/",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = "C_0013"
    },
    new()
    {
      CustodianCode = "4615", Name = "Dudley Metropolitan Borough Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.dudley.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "9058", Name = "Dumfries and Galloway Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.dumgal.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "1355", Name = "Durham County Council", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//www.durham.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "5270", Name = "London Borough of Ealing", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//www.ealing.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0017"
    },
    new()
    {
      CustodianCode = "9060", Name = "East Ayrshire Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.east-ayrshire.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "510", Name = "East Cambridgeshire District Council", Status = Hug2Status.Live,
      WebsiteUrl = "http=//www.eastcambs.gov.uk/", IncomeThreshold = IncomeThreshold._34500,
      ConsortiumCode = "C_0006"
    },
    new()
    {
      CustodianCode = "1105", Name = "East Devon District Council", Status = Hug2Status.Live,
      WebsiteUrl = "http=//eastdevon.gov.uk", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0014"
    },
    new()
    {
      CustodianCode = "9061", Name = "East Dunbartonshire Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.eastdunbarton.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "1710", Name = "East Hampshire District Council", Status = Hug2Status.Live,
      WebsiteUrl = "http=//www.easthants.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0031"
    },
    new()
    {
      CustodianCode = "1915", Name = "East Hertfordshire District Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.eastherts.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0007"
    },
    new()
    {
      CustodianCode = "2510", Name = "East Lindsey District Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.e-lindsey.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "9062", Name = "East Lothian Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.eastlothian.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "9063", Name = "East Renfrewshire Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "http=//www.eastrenfrewshire.gov.uk",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "2001", Name = "East Riding of Yorkshire Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "http=//www.eastriding.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "3410", Name = "East Staffordshire Borough Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.eaststaffsbc.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "3540", Name = "East Suffolk District Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//www.eastsuffolk.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0038"
    },
    new()
    {
      CustodianCode = "1410", Name = "Eastbourne Borough Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.lewes-eastbourne.gov.uk",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = "C_0021"
    },
    new()
    {
      CustodianCode = "1715", Name = "Eastleigh Borough Council", Status = Hug2Status.Live,
      WebsiteUrl = "http=//www.eastleigh.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0031"
    },
    new()
    {
      CustodianCode = "3605", Name = "Elmbridge Borough Council", Status = Hug2Status.Live,
      WebsiteUrl = "http=//www.elmbridge.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0039"
    },
    new()
    {
      CustodianCode = "5300", Name = "London Borough of Enfield", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//new.enfield.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0017"
    },
    new()
    {
      CustodianCode = "1535", Name = "Epping Forest District Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.eppingforestdc.gov.uk/",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = "C_0007"
    },
    new()
    {
      CustodianCode = "3610", Name = "Epsom and Ewell Borough Council", Status = Hug2Status.Live,
      WebsiteUrl = "http=//www.epsom-ewell.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0039"
    },
    new()
    {
      CustodianCode = "1025", Name = "Erewash Borough Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.erewash.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "1110", Name = "Exeter City Council", Status = Hug2Status.Live, WebsiteUrl = "https=//exeter.gov.uk/",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = "C_0014"
    },
    new()
    {
      CustodianCode = "9065", Name = "Falkirk Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.falkirk.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "1720", Name = "Fareham Borough Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//www.fareham.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0031"
    },
    new()
    {
      CustodianCode = "515", Name = "Fenland District Council", Status = Hug2Status.Live,
      WebsiteUrl = "http=//www.fenland.gov.uk/", IncomeThreshold = IncomeThreshold._34500,
      ConsortiumCode = "C_0006"
    },
    new()
    {
      CustodianCode = "9066", Name = "Fife Council", Status = Hug2Status.NotTakingPart, WebsiteUrl = "https=//www.fife.gov.uk/",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "6835", Name = "Flintshire County Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "http=//www.flintshire.gov.uk", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "2250", Name = "Folkestone and Hythe District Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.folkestone-hythe.gov.uk/home",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = "C_0007"
    },
    new()
    {
      CustodianCode = "1615", Name = "Forest of Dean District Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//www.fdean.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0037"
    },
    new()
    {
      CustodianCode = "2325", Name = "Fylde Borough Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.fylde.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "4505", Name = "Gateshead Metropolitan Borough Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.gateshead.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "3020", Name = "Gedling Borough Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.gedling.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "1620", Name = "Gloucester City Council", Status = Hug2Status.Live,
      WebsiteUrl = "http=//www.gloucester.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0037"
    },
    new()
    {
      CustodianCode = "1725", Name = "Gosport Borough Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//www.gosport.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0031"
    },
    new()
    {
      CustodianCode = "2230", Name = "Gravesham Borough Council", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//www.gravesham.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0007"
    },
    new()
    {
      CustodianCode = "2615", Name = "Great Yarmouth Borough Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.great-yarmouth.gov.uk", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "5330", Name = "Royal Borough of Greenwich", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//www.royalgreenwich.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0017"
    },
    new()
    {
      CustodianCode = "3615", Name = "Guildford Borough Council", Status = Hug2Status.Live,
      WebsiteUrl = "http=//www.guildford.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0039"
    },
    new()
    {
      CustodianCode = "6810", Name = "Gwynedd Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.gwynedd.llyw.cymru/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "5360", Name = "London Borough of Hackney", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//www.hackney.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0017"
    },
    new()
    {
      CustodianCode = "650", Name = "Halton Borough Council", Status = Hug2Status.Live, WebsiteUrl = "http=//www.halton.gov.uk/",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = "C_0022"
    },
    new()
    {
      CustodianCode = "5390", Name = "London Borough of Hammersmith & Fulham", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//www.lbhf.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0017"
    },
    new()
    {
      CustodianCode = "2415", Name = "Harborough District Council", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//www.harborough.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "1540", Name = "Harlow Council", Status = Hug2Status.Pending, WebsiteUrl = "http=//www.harlow.gov.uk/",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = "C_0007"
    },
    new()
    {
      CustodianCode = "5450", Name = "London Borough of Harrow", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.harrow.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0017"
    },
    new()
    {
      CustodianCode = "1730", Name = "Hart District Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.hart.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0007"
    },
    new()
    {
      CustodianCode = "724", Name = "Hartlepool Borough Council", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//www.hartlepool.gov.uk", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0012"
    },
    new()
    {
      CustodianCode = "1415", Name = "Hastings Borough Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.hastings.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0021"
    },
    new()
    {
      CustodianCode = "1735", Name = "Havant Borough Council", Status = Hug2Status.Live,
      WebsiteUrl = "http=//www.havant.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0031"
    },
    new()
    {
      CustodianCode = "5480", Name = "London Borough of Havering", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.havering.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0007"
    },
    new()
    {
      CustodianCode = "1850", Name = "Herefordshire Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.herefordshire.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "1920", Name = "Hertsmere Borough Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.hertsmere.gov.uk/home.aspx",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = "C_0007"
    },
    new()
    {
      CustodianCode = "1030", Name = "High Peak Borough Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.highpeak.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "9068", Name = "The Highland Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.highland.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "5510", Name = "London Borough of Hillingdon", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.hillingdon.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0017"
    },
    new()
    {
      CustodianCode = "2420", Name = "Hinckley and Bosworth Borough Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.hinckley-bosworth.gov.uk/",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "3825", Name = "Horsham District Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//www.horsham.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0031"
    },
    new()
    {
      CustodianCode = "520", Name = "Huntingdonshire District Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//www.huntingdonshire.gov.uk/",
      IncomeThreshold = IncomeThreshold._34500, ConsortiumCode = "C_0006"
    },
    new()
    {
      CustodianCode = "2330", Name = "Hyndburn Borough Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//www.hyndburnbc.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0002"
    },
    new()
    {
      CustodianCode = "9069", Name = "Inverclyde Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.inverclyde.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "3515", Name = "Ipswich Borough Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//www.ipswich.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0038"
    },
    new()
    {
      CustodianCode = "6805", Name = "Isle of Anglesey County Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.anglesey.gov.uk", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "2114", Name = "Isle of Wight Council", Status = Hug2Status.Live, WebsiteUrl = "https=//www.iow.gov.uk/",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = "C_0031"
    },
    new()
    {
      CustodianCode = "835", Name = "Council of the Isles of Scilly", Status = Hug2Status.Live,
      WebsiteUrl = "http=//www.scilly.gov.uk", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0010"
    },
    new()
    {
      CustodianCode = "5570", Name = "London Borough of Islington", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.islington.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0017"
    },
    new()
    {
      CustodianCode = "5600", Name = "Royal Borough of Kensington and Chelsea", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.rbkc.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0017"
    },
    new()
    {
      CustodianCode = "2635", Name = "Borough Council of Kings Lynn and West Norfolk", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//www.west-norfolk.gov.uk", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0004"
    },
    new()
    {
      CustodianCode = "2004", Name = "Hull City Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.hull.gov.uk", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "5630", Name = "Royal Borough of Kingston upon Thames", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.kingston.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0017"
    },
    new()
    {
      CustodianCode = "4715", Name = "Kirklees Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.kirklees.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "4305", Name = "Knowsley Metropolitan Borough Council", Status = Hug2Status.Live,
      WebsiteUrl = "http=//www.knowsley.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0022"
    },
    new()
    {
      CustodianCode = "5660", Name = "London Borough of Lambeth", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//www.lambeth.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0017"
    },
    new()
    {
      CustodianCode = "2335", Name = "Lancaster City Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//www.lancaster.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0002"
    },
    new()
    {
      CustodianCode = "4720", Name = "Leeds City Council", Status = Hug2Status.Live, WebsiteUrl = "https=//www.leeds.gov.uk/",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "2465", Name = "Leicester City Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//www.leicester.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "1425", Name = "Lewes District Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.lewes-eastbourne.gov.uk",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = "C_0021"
    },
    new()
    {
      CustodianCode = "5690", Name = "London Borough of Lewisham", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//lewisham.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0017"
    },
    new()
    {
      CustodianCode = "3415", Name = "Lichfield District Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.lichfielddc.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "2515", Name = "City of Lincoln Council", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//www.lincoln.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "4310", Name = "Liverpool City Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//liverpool.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0022"
    },
    new()
    {
      CustodianCode = "5180", Name = "London Borough of Bromley", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.bromley.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0017"
    },
    new()
    {
      CustodianCode = "5420", Name = "London Borough of Haringey", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.haringey.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0017"
    },
    new()
    {
      CustodianCode = "5540", Name = "London Borough of Hounslow", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.hounslow.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0017"
    },
    new()
    {
      CustodianCode = "230", Name = "Luton Borough Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.luton.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "2235", Name = "Maidstone Borough Council", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//www.maidstone.gov.uk", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0007"
    },
    new()
    {
      CustodianCode = "1545", Name = "Maldon District Council", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//www.maldon.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0007"
    },
    new()
    {
      CustodianCode = "1820", Name = "Malvern Hills District Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.malvernhills.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "4215", Name = "Manchester City Council", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//www.manchester.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "3025", Name = "Mansfield District Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.mansfield.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "2280", Name = "Medway Council", Status = Hug2Status.Pending, WebsiteUrl = "https=//www.medway.gov.uk/",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = "C_0007"
    },
    new()
    {
      CustodianCode = "2430", Name = "Melton Borough Council", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//www.melton.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "6925", Name = "Merthyr Tydfil County Borough Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.merthyr.gov.uk", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "5720", Name = "London Borough of Merton", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//www.merton.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0017"
    },
    new()
    {
      CustodianCode = "1135", Name = "Mid Devon District Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//www.middevon.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0014"
    },
    new()
    {
      CustodianCode = "3520", Name = "Mid Suffolk District Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//www.midsuffolk.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0038"
    },
    new()
    {
      CustodianCode = "3830", Name = "Mid Sussex District Council", Status = Hug2Status.Live,
      WebsiteUrl = "http=//www.midsussex.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0031"
    },
    new()
    {
      CustodianCode = "734", Name = "Middlesbrough Borough Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "http=//www.middlesbrough.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "9070", Name = "Midlothian Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.midlothian.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "435", Name = "Milton Keynes Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.milton-keynes.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0007"
    },
    new()
    {
      CustodianCode = "3620", Name = "Mole Valley District Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//www.molevalley.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0039"
    },
    new()
    {
      CustodianCode = "6840", Name = "Monmouthshire County Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.monmouthshire.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "9071", Name = "The Moray Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "http=//www.moray.gov.uk", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "6930", Name = "Neath Port Talbot County Borough Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "http=//www.neath-porttalbot.gov.uk",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "1740", Name = "New Forest District Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//www.newforest.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0031"
    },
    new()
    {
      CustodianCode = "3030", Name = "Newark and Sherwood District Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.newark-sherwooddc.gov.uk/",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "4510", Name = "Newcastle City Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//www.newcastle.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "3420", Name = "Newcastle-under-Lyme District Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.newcastle-staffs.gov.uk/",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "5750", Name = "London Borough of Newham", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.newham.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0017"
    },
    new()
    {
      CustodianCode = "6935", Name = "Newport City Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.newport.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "9072", Name = "North Ayrshire Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.north-ayrshire.gov.uk/",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "1115", Name = "North Devon Council", Status = Hug2Status.Live,
      WebsiteUrl = "http=//www.northdevon.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0014"
    },
    new()
    {
      CustodianCode = "1035", Name = "North East Derbyshire District Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.ne-derbyshire.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "2002", Name = "North East Lincolnshire Council", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//www.nelincs.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "1925", Name = "North Hertfordshire District Council", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//www.north-herts.gov.uk", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0007"
    },
    new()
    {
      CustodianCode = "2520", Name = "North Kesteven District Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.n-kesteven.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "9073", Name = "North Lanarkshire Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.northlanarkshire.gov.uk/",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "2003", Name = "North Lincolnshire Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.northlincs.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "2620", Name = "North Norfolk District Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.north-norfolk.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0004"
    },
    new()
    {
      CustodianCode = "2840", Name = "North Northamptonshire Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.northnorthants.gov.uk/",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = "C_0007"
    },
    new()
    {
      CustodianCode = "121", Name = "North Somerset Council", Status = Hug2Status.Live,
      WebsiteUrl = "http=//www.n-somerset.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0003"
    },
    new()
    {
      CustodianCode = "4515", Name = "North Tyneside Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//my.northtyneside.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "3705", Name = "North Warwickshire Borough Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.northwarks.gov.uk/site/",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "2435", Name = "North West Leicestershire District Council", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//www.nwleics.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "2745", Name = "North Yorkshire County Council", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//www.northyorks.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0027"
    },
    new()
    {
      CustodianCode = "2935", Name = "Northumberland County Council", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//www.northumberland.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "2625", Name = "Norwich City Council", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//www.norwich.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0004"
    },
    new()
    {
      CustodianCode = "3060", Name = "Nottingham City Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.nottinghamcity.gov.uk/",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "3710", Name = "Nuneaton and Bedworth Borough Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.nuneatonandbedworth.gov.uk/site/",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "2440", Name = "Oadby and Wigston District Council", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//oadby-wigston.gov.uk/Home/Home.aspx",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "4220", Name = "Oldham Metropolitan Borough Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.oldham.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "7655", Name = "Ordnance Survey", Status = Hug2Status.NotTakingPart, WebsiteUrl = "",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "9000", Name = "Orkney Islands Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.orkney.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "3110", Name = "Oxford City Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.oxford.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0029"
    },
    new()
    {
      CustodianCode = "6845", Name = "Pembrokeshire County Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "http=//www.pembrokeshire.gov.uk", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "2340", Name = "Pendle Borough Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//www.pendle.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0002"
    },
    new()
    {
      CustodianCode = "9074", Name = "Perth and Kinross Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.pkc.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "540", Name = "Peterborough City Council", Status = Hug2Status.Live,
      WebsiteUrl = "http=//www.peterborough.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0031"
    },
    new()
    {
      CustodianCode = "1160", Name = "Plymouth City Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//www.plymouth.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "1775", Name = "Portsmouth City Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//www.portsmouth.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0031"
    },
    new()
    {
      CustodianCode = "6850", Name = "Powys County Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "http=//www.powys.gov.uk", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "2345", Name = "Preston City Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//www.preston.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0002"
    },
    new()
    {
      CustodianCode = "345", Name = "Reading Borough Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.reading.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0007"
    },
    new()
    {
      CustodianCode = "5780", Name = "London Borough of Redbridge", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.redbridge.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0017"
    },
    new()
    {
      CustodianCode = "728", Name = "Redcar and Cleveland Borough Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.redcar-cleveland.gov.uk/",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = "C_0012"
    },
    new()
    {
      CustodianCode = "1825", Name = "Redditch Borough Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.redditchbc.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "3625", Name = "Reigate and Banstead Borough Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//www.reigate-banstead.gov.uk/",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = "C_0039"
    },
    new()
    {
      CustodianCode = "9075", Name = "Renfrewshire Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.renfrewshire.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "6940", Name = "Rhondda Cynon Taf County Borough Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.rctcbc.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "2350", Name = "Ribble Valley Borough Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//www.ribblevalley.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0002"
    },
    new()
    {
      CustodianCode = "5810", Name = "London Borough of Richmond upon Thames", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//www.richmond.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0017"
    },
    new()
    {
      CustodianCode = "4225", Name = "Rochdale Metropolitan Borough Council", Status = Hug2Status.Live,
      WebsiteUrl = "http=//www.rochdale.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "1550", Name = "Rochford District Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.rochford.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0007"
    },
    new()
    {
      CustodianCode = "2355", Name = "Rossendale Borough Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//www.rossendale.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0002"
    },
    new()
    {
      CustodianCode = "1430", Name = "Rother District Council", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//www.rother.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0021"
    },
    new()
    {
      CustodianCode = "4415", Name = "Rotherham Metropolitan Borough Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.rotherham.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "3715", Name = "Rugby Borough Council", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//www.rugby.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "3630", Name = "Runnymede Borough Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//www.runnymede.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0039"
    },
    new()
    {
      CustodianCode = "3040", Name = "Rushcliffe Borough Council", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//www.rushcliffe.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "1750", Name = "Rushmoor Borough Council", Status = Hug2Status.Live,
      WebsiteUrl = "http=//www.rushmoor.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0031"
    },
    new()
    {
      CustodianCode = "2470", Name = "Rutland County Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//www.rutland.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0031"
    },
    new()
    {
      CustodianCode = "4230", Name = "Salford City Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.salford.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "4620", Name = "Sandwell Metropolitan Borough Council", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//www.sandwell.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "9055", Name = "Scottish Borders Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.scotborders.gov.uk", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "4320", Name = "Sefton Metropolitan Borough Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//www.sefton.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0022"
    },
    new()
    {
      CustodianCode = "2245", Name = "Sevenoaks District Council", Status = Hug2Status.Live,
      WebsiteUrl = "http=//www.sevenoaks.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "4420", Name = "Sheffield City Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//www.sheffield.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "9010", Name = "Shetland Islands Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.shetland.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "3245", Name = "Shropshire Council", Status = Hug2Status.Live,
      WebsiteUrl = "http=//www.shropshire.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "350", Name = "Slough Borough Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.slough.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0007"
    },
    new()
    {
      CustodianCode = "4625", Name = "Solihull Metropolitan Borough Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.solihull.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "3300", Name = "Somerset Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.somerset.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "9076", Name = "South Ayrshire Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.south-ayrshire.gov.uk/",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "530", Name = "South Cambridgeshire District Council", Status = Hug2Status.Live,
      WebsiteUrl = "http=//www.scambs.gov.uk/", IncomeThreshold = IncomeThreshold._34500,
      ConsortiumCode = "C_0006"
    },
    new()
    {
      CustodianCode = "1040", Name = "South Derbyshire District Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.southderbyshire.gov.uk",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "119", Name = "South Gloucestershire Council", Status = Hug2Status.Live,
      WebsiteUrl = "http=//www.southglos.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0037"
    },
    new()
    {
      CustodianCode = "1125", Name = "South Hams District Council", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//www.southhams.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0044"
    },
    new()
    {
      CustodianCode = "2525", Name = "South Holland District Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.sholland.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "2530", Name = "South Kesteven District Council", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//www.southkesteven.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "9077", Name = "South Lanarkshire Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.southlanarkshire.gov.uk/",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "2630", Name = "South Norfolk District Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.southnorfolkandbroadland.gov.uk/",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = "C_0004"
    },
    new()
    {
      CustodianCode = "3115", Name = "South Oxfordshire District Council", Status = Hug2Status.Live,
      WebsiteUrl = "http=//www.southoxon.gov.uk", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0029"
    },
    new()
    {
      CustodianCode = "2360", Name = "South Ribble Borough Council", Status = Hug2Status.Live,
      WebsiteUrl = "http=//www.southribble.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0002"
    },
    new()
    {
      CustodianCode = "3430", Name = "South Staffordshire Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.sstaffs.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "4520", Name = "South Tyneside Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "http=//www.southtyneside.gov.uk", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "1780", Name = "Southampton City Council", Status = Hug2Status.Live,
      WebsiteUrl = "http=//www.southampton.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0031"
    },
    new()
    {
      CustodianCode = "1590", Name = "Southend-on-Sea Borough Council", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//www.southend.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0007"
    },
    new()
    {
      CustodianCode = "5840", Name = "London Borough of Southwark", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.southwark.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0017"
    },
    new()
    {
      CustodianCode = "3635", Name = "Spelthorne Borough Council", Status = Hug2Status.Live,
      WebsiteUrl = "http=//www.spelthorne.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0039"
    },
    new()
    {
      CustodianCode = "1930", Name = "St Albans City and District Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.stalbans.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0007"
    },
    new()
    {
      CustodianCode = "4315", Name = "St Helens Council", Status = Hug2Status.Live, WebsiteUrl = "https=//www.sthelens.gov.uk/",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = "C_0022"
    },
    new()
    {
      CustodianCode = "3425", Name = "Stafford Borough Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.staffordbc.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "3435", Name = "Staffordshire Moorlands District Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.staffsmoorlands.gov.uk/",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "1935", Name = "Stevenage Borough Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.stevenage.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0007"
    },
    new()
    {
      CustodianCode = "9078", Name = "Stirling Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//stirling.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "4235", Name = "Stockport Metropolitan Borough Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.stockport.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "738", Name = "Stockton-on-Tees Borough Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.stockton.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0012"
    },
    new()
    {
      CustodianCode = "3720", Name = "Stratford-on-Avon District Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.stratford.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "1625", Name = "Stroud District Council", Status = Hug2Status.Live,
      WebsiteUrl = "http=//www.stroud.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0037"
    },
    new()
    {
      CustodianCode = "4525", Name = "Sunderland City Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.sunderland.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "3640", Name = "Surrey Heath Borough Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//www.surreyheath.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0039"
    },
    new()
    {
      CustodianCode = "5870", Name = "London Borough of Sutton", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.sutton.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0007"
    },
    new()
    {
      CustodianCode = "2255", Name = "Swale Borough Council", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//www.swale.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0007"
    },
    new()
    {
      CustodianCode = "6855", Name = "City and County of Swansea Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.swansea.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "3935", Name = "Swindon Borough Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.swindon.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "4240", Name = "Tameside Metropolitan Borough Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "http=//www.tameside.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "3445", Name = "Tamworth Borough Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.tamworth.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "3645", Name = "Tandridge District Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//www.tandridge.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0039"
    },
    new()
    {
      CustodianCode = "1130", Name = "Teignbridge District Council", Status = Hug2Status.Live,
      WebsiteUrl = "http=//www.teignbridge.gov.uk", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0014"
    },
    new()
    {
      CustodianCode = "3240", Name = "Telford & Wrekin Council", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//www.telford.gov.uk", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "1560", Name = "Tendring District Council", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//www.tendringdc.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0007"
    },
    new()
    {
      CustodianCode = "1760", Name = "Test Valley Borough Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//www.testvalley.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0031"
    },
    new()
    {
      CustodianCode = "1630", Name = "Tewkesbury Borough Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//tewkesbury.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0037"
    },
    new()
    {
      CustodianCode = "2260", Name = "Thanet District Council", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//thanet.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0007"
    },
    new()
    {
      CustodianCode = "1940", Name = "Three Rivers District Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "http=//www.threerivers.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "1595", Name = "Thurrock Council", Status = Hug2Status.Pending, WebsiteUrl = "http=//www.thurrock.gov.uk/",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = "C_0007"
    },
    new()
    {
      CustodianCode = "2265", Name = "Tonbridge and Malling Borough Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//www.tmbc.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0007"
    },
    new()
    {
      CustodianCode = "1165", Name = "Torbay Council", Status = Hug2Status.Live, WebsiteUrl = "http=//www.torbay.gov.uk/",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = "C_0014"
    },
    new()
    {
      CustodianCode = "6945", Name = "Torfaen County Borough Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "http=//www.torfaen.gov.uk", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "1145", Name = "Torridge District Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//www.torridge.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0014"
    },
    new()
    {
      CustodianCode = "5900", Name = "London Borough of Tower Hamlets", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//www.towerhamlets.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0017"
    },
    new()
    {
      CustodianCode = "4245", Name = "Trafford Metropolitan Borough Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "http=//www.trafford.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "2270", Name = "Tunbridge Wells Borough Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.tunbridgewells.gov.uk/",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = "C_0007"
    },
    new()
    {
      CustodianCode = "1570", Name = "Uttlesford District Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.uttlesford.gov.uk/home",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = "C_0007"
    },
    new()
    {
      CustodianCode = "6950", Name = "Vale of Glamorgan Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//valeofglamorgan.gov.uk/en/index.aspx",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "3120", Name = "Vale of White Horse District Council", Status = Hug2Status.Live,
      WebsiteUrl = "http=//www.whitehorsedc.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0029"
    },
    new()
    {
      CustodianCode = "4725", Name = "Wakefield Metropolitan District Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//www.wakefield.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "4630", Name = "Walsall Metropolitan Borough Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//go.walsall.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "5930", Name = "London Borough of Waltham Forest", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.walthamforest.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0017"
    },
    new()
    {
      CustodianCode = "5960", Name = "London Borough of Wandsworth", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.wandsworth.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0017"
    },
    new()
    {
      CustodianCode = "655", Name = "Warrington Borough Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.warrington.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "3725", Name = "Warwick District Council", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//www.warwickdc.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "1945", Name = "Watford Borough Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.watford.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "3650", Name = "Waverley Borough Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//www.waverley.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0039"
    },
    new()
    {
      CustodianCode = "1435", Name = "Wealden District Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//www.wealden.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "1950", Name = "Welwyn Hatfield Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.welhat.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0007"
    },
    new()
    {
      CustodianCode = "340", Name = "West Berkshire Council", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//www.westberks.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0007"
    },
    new()
    {
      CustodianCode = "1150", Name = "West Devon Borough Council", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//www.westdevon.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0044"
    },
    new()
    {
      CustodianCode = "9057", Name = "West Dunbartonshire Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.west-dunbarton.gov.uk/",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "2365", Name = "West Lancashire Borough Council", Status = Hug2Status.Live,
      WebsiteUrl = "http=//www.westlancs.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0002"
    },
    new()
    {
      CustodianCode = "2535", Name = "West Lindsey District Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.west-lindsey.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "9079", Name = "West Lothian Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.westlothian.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "2845", Name = "West Northamptonshire Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.westnorthants.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0007"
    },
    new()
    {
      CustodianCode = "3125", Name = "West Oxfordshire District Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//www.westoxon.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0029"
    },
    new()
    {
      CustodianCode = "3545", Name = "West Suffolk District Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//www.westsuffolk.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0038"
    },
    new()
    {
      CustodianCode = "9020", Name = "Comhairle nan Eilean Siar", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.cne-siar.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "935", Name = "Westmorland and Furness Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "https=//www.westmorlandandfurness.gov.uk/",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = "C_0016"
    },
    new()
    {
      CustodianCode = "4250", Name = "Wigan Metropolitan Borough Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "http=//www.wigan.gov.uk", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "3940", Name = "Wiltshire Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.wiltshire.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "1765", Name = "Winchester City Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//www.winchester.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0031"
    },
    new()
    {
      CustodianCode = "355", Name = "Royal Borough of Windsor and Maidenhead", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//www.rbwm.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0007"
    },
    new()
    {
      CustodianCode = "4325", Name = "Wirral Council", Status = Hug2Status.Live, WebsiteUrl = "http=//www.wirral.gov.uk/",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "3655", Name = "Woking Borough Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//www.woking.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0039"
    },
    new()
    {
      CustodianCode = "360", Name = "Wokingham Borough Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.wokingham.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0007"
    },
    new()
    {
      CustodianCode = "4635", Name = "City of Wolverhampton Council", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//www.wolverhampton.gov.uk", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "1835", Name = "Worcester City Council", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//www.worcester.gov.uk", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "3835", Name = "Worthing Borough Council", Status = Hug2Status.Live,
      WebsiteUrl = "https=//www.adur-worthing.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0031"
    },
    new()
    {
      CustodianCode = "6955", Name = "Wrexham County Borough Council", Status = Hug2Status.NotTakingPart,
      WebsiteUrl = "http=//www.wrexham.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    },
    new()
    {
      CustodianCode = "1840", Name = "Wychavon District Council", Status = Hug2Status.Pending,
      WebsiteUrl = "http=//www.wychavon.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "2370", Name = "Wyre Council", Status = Hug2Status.Live, WebsiteUrl = "http=//www.wyre.gov.uk",
      IncomeThreshold = IncomeThreshold._31000, ConsortiumCode = "C_0002"
    },
    new()
    {
      CustodianCode = "1845", Name = "Wyre Forest District Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.wyreforestdc.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = "C_0024"
    },
    new()
    {
      CustodianCode = "2741", Name = "City of York Council", Status = Hug2Status.Pending,
      WebsiteUrl = "https=//www.york.gov.uk/", IncomeThreshold = IncomeThreshold._31000,
      ConsortiumCode = null
    }
  };
}