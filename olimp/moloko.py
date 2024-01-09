f = open('input.txt')
n = int(f.readline())
b = [1000, 1000]
for i in range(1, n + 1):
    x1, y1, z1, x2, y2, z2, c1, c2 = map(float, f.readline().split())
    v1 = x1 * y1 * z1 / 1000
    v2 = x2 * y2 * z2 / 1000
    s1 = 2 * (x1 * y1 + x1 * z1 + y1 * z1)
    s2 = 2 * (x2 * y2 + x2 * z2 + y2 * z2)
    m = round(abs((s2 * c1 / s1 - c2) / (s2 * v1 / s1 - v2)), 2)
    if b[1] > m:
        b = [i, m]
print(b)