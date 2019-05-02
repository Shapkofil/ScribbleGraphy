import pyautogui

def moveMouse(x,y,winh,winw):
	w,h = pyautogui.size()[0] , pyautogui.size()[1]
	x = (x*w)/winw
	y = (y*h)/winh
	if x>=0 and y>=0:
		pyautogui.moveTo(x,y)