import cv2
import numpy as np

def maskcolor(frame,color,sensitivity):
	hsv = cv2.cvtColor(frame , cv2.COLOR_BGR2HSV)
	
	darkblue = np.array([color-sensitivity,70,70])
	ligthblue = np.array([color+sensitivity,255,255])

	mask = cv2.inRange(hsv,darkblue,ligthblue)
	track = cv2.bitwise_and(frame,frame,mask = mask)

	return track,mask

def Tracktor(mask,frame):
	contours,hirarchy = cv2.findContours(mask,cv2.RETR_TREE,cv2.CHAIN_APPROX_SIMPLE)
	
	if len(contours)==0:
		return [],-1,-1

	cnt = max(contours,key = cv2.contourArea)
	x,y,w,h = cv2.boundingRect(cnt)
	#frame = cv2.rectangle(frame,(x,y),(x+w,y+h),(0,255,0),3)
	frame = cv2.circle(frame,(int(x+w/2),int(y+h/2)),3,(0,127,255),2)

	return frame,int(x+(w/2)),int(y+(h/2))
