import maskColor as mc
import mousemover as mm
import cv2
import numpy as np
import pyautogui

cap = cv2.VideoCapture(1)

okflag,frame = cap.read()

while okflag:
	#inverting the image
	frame = cv2.flip(frame,1)
	#making track mask
	track,mask = mc.maskcolor(frame,60,15)

	contours,x,y = mc.Tracktor(mask,frame)
	#debug window
	cv2.imshow('track',frame)

	mm.moveMouse(x,y,frame.shape[0],frame.shape[1])
	#reading from the camera
	okflag,frame = cap.read()

	if cv2.waitKey(33) == ord('q'):
		break

cv2.imwrite('faggot.png',frame)
cap.release()
cv2.destroyAllWindows()