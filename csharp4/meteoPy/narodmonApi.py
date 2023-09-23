import urllib.request
import json

api_key = 'vXU31e7cGz1M7'
md5_app_id = '783f2f44a073ee00102b316f119b8ac4'

# 86324 - айнабулак темп, 86326 - айнабулак АД, 97412 - станица темп1, 97417 - станица темп2, 97415 - станица АД, 97413 - станица влажность, 60068 - горы темп, 24925 - горы влажность

def narodmonApi(deviceId):

    data = {
    'cmd': 'sensorsValues',
    'uuid': md5_app_id,
    'api_key': api_key,
    'sensors': [86324, 97412, 60068, 97415, 97413],
    'lang': 'ru'
    }

    try:
        request = urllib.request.Request('http://narodmon.ru/api', json.dumps(data).encode())
        response = urllib.request.urlopen(request)
        result = json.loads(response.read().decode())

        #return resultа
    
        print(json.dumps(result, indent=4, sort_keys=True))
    except urllib.error.URLError as e:
        print('HTTP error:', e)
    except (ValueError, TypeError) as e:
        print('JSON error:', e)

result = narodmonApi(8622)

def GetDeviceInfo(result):

    deviceId = result["devices"][0]["id"]
    deviceName = result["devices"][0]["name"]
    deviceLocation = result["devices"][0]["location"]

    return deviceId, deviceName, deviceLocation

