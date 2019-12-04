import numpy as np
import matplotlib.pyplot as plt
G = 6.67*10**(-11) #Гравитационная постоянная
def slowpoke(m,t1):
    c = 299792458 #Скорость света в вакууме
    chs=2*G*m/c**2 #Гравитационный радиус
    edge = 3*chs #Границы графика
    r = np.arange(chs, edge, 0.01*chs) #Расстояние от центра гравитирующего тела
    t2 = t1 *(1 - chs/r)**0.5 #Замедленное время
    plt.plot(r, t2)
    plt.xlabel('radius')
    plt.ylabel('time two')
    plt.title('Релятивистское Замедление Времени')
    plt.savefig('picture1.png')
    
slowpoke(10**30,125)    
slowpoke(10**30,100)

def func_time(m,t1,r):
    c = 299792458 
    chs=2*G*m/c**2
    t2 = t1 *(1 - chs/r)**0.5
    return t2

time_earth = func_time(5.97*10**24, 1, 6371000)
time_evirest = func_time(5.97*10**24, 1, 6379848)
print (time_earth, time_evirest  )
delta_time = time_evirest - time_earth
print(10**12/(3600*24*365))
