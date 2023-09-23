import sqlite3

from narodmonApi import narodmonApi

conn = sqlite3.connect('meteo.db')
cursor = conn.cursor()

cursor.execute('''CREATE TABLE IF NOT EXISTS devices 
            (deviceId INTEGER,
            deviceLocation TEXT,
            deviceName TEXT)''')

def writeDevices(deviceId, deviceName, deviceLocation):

    cursor.execute('''INSERT OR IGNORE INTO devices 
                (deviceId, deviceLocation, deviceName) 
                VALUES (?, ?, ?)''', (deviceId, deviceName, deviceLocation))

    conn.commit()

deviceId, deviceName, deviceLocation = narodmonApi(8625)
writeDevices(deviceId, deviceName, deviceLocation)

cursor.execute("SELECT * FROM devices;")
rows = cursor.fetchall()

for row in rows:
    print(row)

cursor.close()