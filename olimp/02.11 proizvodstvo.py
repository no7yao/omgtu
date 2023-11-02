from datetime import datetime, timedelta
start = input("ДД.ММ.ГГГГ")
end = input("ДД.ММ.ГГГГ")
p = int(input("начальный выпуск"))
start1 = datetime.strptime(start, '%d.%m.%Y')
end1 = datetime.strptime(end, '%d.%m.%Y')
delta = end1 - start1
cntden = delta.days + 1
vse = p * cntden + (cntden * (cntden - 1) // 2)
print(vse)