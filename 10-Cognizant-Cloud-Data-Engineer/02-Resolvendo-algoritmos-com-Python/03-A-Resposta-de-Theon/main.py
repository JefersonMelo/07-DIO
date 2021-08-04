N = int(input())

entrada = list(map(int, input().split()))

minimo = min(entrada)

print(entrada.index(minimo) + 1)
