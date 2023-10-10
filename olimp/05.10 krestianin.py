maxn = int(input())
cnt = maxn

i = 2
while (2 ** i) - 1 <= maxn:
    cnt += maxn // ((2 ** i) - 1)
    i += 1

print(cnt)

