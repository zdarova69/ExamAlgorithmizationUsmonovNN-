import random
import datetime
today = datetime.date.today()
all = []
for i in range(7):
    ras = today - datetime.timedelta(days=i)
    all.append(ras)
data_izgotov = random.choice(all)
price = random.randint(100,1000)
crok = random.randint(1,7)
print = (f"Дата изготовления: {data_izgotov}")
print = (f"Цена: {price}")
print = (f"Срок: {crok}")

raz = (today - data_izgotov).days
if raz == 0:
    print(f"Цена: {price}")
elif raz>1 and raz==crok:
    o= (price - (price*0.2))
    print(f"Товар просрочен на {raz}, цена: {price}")
else:
    print("Бесплатно")

