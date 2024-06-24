# Problem 1
- Musicana records have decided to store information on musicians who perform on their albums in a database. The company has wisely chosen to hire you as a database designer.
- Each musician that is recorded at Musicana has an ID number, a name, an address (street, city) and a phone number.
- Each instrument that is used in songs recorded at Musicana has a unique name and a musical key (e.g., C, B-flat, E-flat).
- Each album that is recorded at the Musicana label has a unique title, a copyright date, and an album id
entifier.
- Each song recorded at Musicana has a unique title and an author.
- Each musician may play several instruments, and a given instrument may be played by several musicians.
- Each album has a number of songs on ita and song must appear on one ablum.
- Each song is performed by one or more musicians, and a musician may perform a number of songs.
- Each album has exactly one musician who acts as its producer. A producer may produce several albums.

- Design a conceptual schema for Musicana. Be sure to indicate all keys and cardinality constraints and any assumptions that you make.
	
# Problem 2
- Prepare an E-R diagram for a real estate firm that lists properties for sale. The following describes this organization:u6  m
- The firm has a number of sales offices in several states. Attributes of sales office include Office_Number and Location.
- Each sales office is assigned zero or more employees. Attributes of employee include Employee_ID  and Employee_Name. An employee must be assigned to only one sales office.
- For each sales office, there is always one employee assigned to manage that office and manager can’t manage many sales office at the same time. 
- The firm lists property for sale. Attributes of property include Property_ID and Location. Components of Location include Address, City, State, and Zip_Code.
- Each property must be listed with one (and only one) of the sales offices. A sales office may have any number of properties listed, or may have no properties listed.
- Each property may have zero or more owners. Attributes of owners are Owner_ID and Owner_Name. An owner own one or more properties. The system stores the percent owned by each owner in each property.

# Problem 3
- A General Hospital consists of a number of specialized wards. Each ward is described by ward_id, Name
- The system records the following details about patients: Patient_id, name, Date_Of_Birth
- Each ward may host more patients and each patient is hosted by only one ward.
- Each patient is assigned to one leading consultant but may be examined by other consultants, if required. 
- Each consultant may be assigned zero or more patients and may examine zero or more patients.
- Consultants are described by Consultant_id, Name
- The system has to record all required data each time the Nurse gives a patient a certain drug with specified dosage at certain date and time.
- Each ward is under supervision of one nurse and a nurse may supervise only one ward. 
- Each Nurse must serve in one ward and ward can have many nurses.
- Data about the nurse is recorded as her name and her number and her address. 
- A drug has code number, recommended dosage and more than one brand name
