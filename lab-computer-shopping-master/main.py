# initial laptops given
msi_rtxa5000_price = 4199.35
gigabyte_aero_price = 4295.54
razer_blade15_price = 3696.99
asus_zephyrus_m16_price = 1849.79
# 3 other laptops
acer_nitro_5_price = 1099.99
alienware_x15_r1_price = 2199.99
msi_gf65_price = 799.99
# string i don't want to type over and over
roundx = 'The rounded price of the '
# expensive, cheapest
print(f'The most expensive laptop costs: {max(msi_rtxa5000_price,gigabyte_aero_price,razer_blade15_price,asus_zephyrus_m16_price,acer_nitro_5_price,alienware_x15_r1_price,msi_gf65_price)}')
print(f'The cheapest laptop costs: {min(msi_rtxa5000_price,gigabyte_aero_price,razer_blade15_price,asus_zephyrus_m16_price,acer_nitro_5_price,alienware_x15_r1_price,msi_gf65_price)}')
# rounding, tried to make this an iteration but gave up
print(f'{roundx} MSI RTX 5000 is {round(msi_rtxa5000_price)}')
print(f'{roundx} Gigabyte Aero is {round(gigabyte_aero_price)}')
print(f'{roundx} Razer Blade 15 is {round(razer_blade15_price)}')
print(f'{roundx} Asus Zephyrus is {round(asus_zephyrus_m16_price)}')
# other laptops vv, initial laptops ^^
print(f'{roundx} Acer Nitro 5 is {round(acer_nitro_5_price)}')
print(f'{roundx} Alienware x15 R1 is {round(alienware_x15_r1_price)}')
print(f'{roundx} MSI GF65 is {round(msi_gf65_price)}')
# find average -- https://www.geeksforgeeks.org/find-average-list-python/
def avrg(laptops):
    return sum(laptops) / len(laptops)
laptops = [msi_rtxa5000_price,gigabyte_aero_price,razer_blade15_price,asus_zephyrus_m16_price,acer_nitro_5_price,alienware_x15_r1_price,msi_gf65_price]
average = avrg(laptops)
print('The average price of all computers is', round(average,2))