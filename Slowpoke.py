import numpy as np
from constant import G
import matplotlib.pyplot as plt
def slowpoke(m,t1):
    c = 299792458 
    chs=2*G*m/c**2
    ch = 3*chs
    r = np.arange(chs, ch, 0.01*chs)
    t2 = t1 *(1 - chs/r)**0.5
    plt.plot(r, t2)
    plt.xlabel('radius')
    plt.ylabel('time two')
    plt.title('Релятивистское Замедление Времени')
    plt.show()
slowpoke(10**30,100)

def slowpoke2(m,t1):
    c = 299792458 
    chs=2*G*m/c**2
    ch = 3*chs
    r = np.arange(chs, ch, 0.01*chs)
    t2 = t1 *(1 - chs/r)**0.5
    plt.plot(r, t2)
    plt.xlabel('radius')
    plt.ylabel('time two')
    plt.title('Релятивистское Замедление Времени')
    plt.show()
slowpoke2(10**28,300)
 