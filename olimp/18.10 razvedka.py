n = int(input())
def sold(n):
    if n < 3:
        return 0
    if n == 3:
        return 1
    n1 = n // 2
    n2 = n - n1
    rec = sold(n1) + sold(n2)
    return (rec)
print(sold(n))
