P=int(input('путь до грядки'))
K=int(input('ширина грядки'))
L=int(input('длина грядки'))
N=int(input('кол-во грядок'))
print((N*2*(K+L+P))+K*N*(N-1))

P=int(input('путь до грядки'))
K=int(input('ширина грядки'))
L=int(input('длина грядки'))
N=int(input('кол-во грядок'))
i=1
S=0
while i <= N:
    S=S+((2*P)+K*2*(i-1)+2*K+2*L)
    i +=1
print(S)