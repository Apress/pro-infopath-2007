CREATE ENDPOINT get_Customer_History
STATE=STARTED
AS HTTP(
    SITE = '[servername]',
    PATH = '/sql/demo',
    AUTHENTICATION = ( INTEGRATED ),
    PORTS = ( CLEAR )
)
FOR SOAP (
    WEBMETHOD 
        'http://[servername]/'.'CustOrderHist'
        (NAME='Northwind.dbo.CustOrderHist'),
        BATCHES = ENABLED,
        WSDL = DEFAULT
)
