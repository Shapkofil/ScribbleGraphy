import cv2
import numpy as np

def gaussination(frame):
	blue,green,red = cv2.split(frame)
	blue = cv2.adaptiveThreshold(blue,255,cv2.ADAPTIVE_THRESH_GAUSSIAN_C,\
		cv2.THRESH_BINARY,3,1)
	green = cv2.adaptiveThreshold(green,255,cv2.ADAPTIVE_THRESH_GAUSSIAN_C,\
		cv2.THRESH_BINARY,3,1)
	red = cv2.adaptiveThreshold(red,255,cv2.ADAPTIVE_THRESH_GAUSSIAN_C,\
		cv2.THRESH_BINARY,3,1)
	frame = cv2.merge((blue,green,red))
	return frame