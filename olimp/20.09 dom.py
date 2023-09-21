x = int(input('длина новой стены 1'))
y = int(input('длина новой стены 2'))
l = int(input('длина уцелевшей стены'))
c1 = int(input('цена ремонта стены'))
c2 = int(input('цена разбора стены'))
c3 = int(input('цена стр из материала уцелевшей стены'))
c4 = int(input('цена стр из нового материала'))
c5 = int(input('цена нового материала'))
c6 = int(input('цена вывоза на свалку'))
p = 2 * (x + y)
newbb = c4 + c5
cena = 0
if l > max(x, y):
    cena = (l - max(x, y)) * c2
    ost = l - max(x, y)
    if (c2 + c6 + newbb > c1) and (c2 + c3 > c1):
        cena = cena + max(x, y)*c1
    elif (c2 + c6 + newbb > c2 + c3):
        cena = cena + max(x, y) * (c2 + c3)
    else:
        cena = cena + max(x, y) * (newbb + c6 + c2)
    p = p - max(x, y)
    if c3 < newbb + c6:
        if ost <= p:
            p = p - ost
            cena = cena + ost * c3
            cena = cena + p * newbb
        else:
            cena = cena + p * c3 + (ost - p) * c6
            p = 0
    else:
        cena = cena + p * newbb + ost * c6
        p = 0
elif l <= max(x, y):
    if (c2 + c3 > c1) and (c2 + c6 + newbb > c1):
        cena = cena + l * c1
    elif (c2 + c6 + newbb > c2 + c3):
        cena = cena + l * (c2 + c3)
    else:
        cena = cena + l * (newbb + c6 + c2)
    p = p - l
    cena = p * newbb + cena
print(cena)
