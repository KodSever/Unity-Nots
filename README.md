# UNITY NOTLARIM

Overlay Ui bağlı menuler sabit kalıyor
World ise menuler etkileniyor


Ui image yuvarlak köşeler

Event Trigger ekleyip card nesnesini bağlayıp Kullanılabilir Drag olur

OnDrag nesnenin drag olamasıdır. transform.position = eventdata.position ile taşınır

IBeginDragHandler,
IDragHandler,	
IEndDragHandler

Child Force Expand: width kartları yayar boyutunu değiştirmez(Yatay olarak)

Layout element script: Kesin kurallarının olduğunu söyler
	Flexible Width = 1 esnek 0 ise esnek değil

Prefered Width: Tercih edilen genişlik(Tercih eder) flexible 0 ise zorunlu kılmış olur

GetComponent<CanvasGroup>() ışın çarpsın mı demek
IBeginDragHandler yaparsın nesneyi taşımana izin verir. GetComponent<CanvasGroup>().blocksRaycasts = false;
IEndDragHandler yaparsın nesneyi ileride taşımana izin verir. GetComponent<CanvasGroup>().blocksRaycasts = true;
