/*
 *	Hardware defnition for
 *	Raspberry Pi 3 model B & Raspberry Pi 2 model B
 *	Author:raiden325
 */
#ifndef __GPIORASPPI3_H__
#define __GPIORASPPI3_H__
#endif

/* Bit */
#define BIT_0			( 0x00000001 )
#define BIT_1			( 0x00000002 )
#define BIT_2			( 0x00000004 )
#define BIT_3			( 0x00000008 )
#define BIT_4			( 0x00000010 )
#define BIT_5			( 0x00000020 )
#define BIT_6			( 0x00000040 )
#define BIT_7			( 0x00000080 )
#define BIT_8			( 0x00000100 )
#define BIT_9			( 0x00000200 )
#define BIT_10			( 0x00000400 )
#define BIT_11			( 0x00000800 )
#define BIT_12			( 0x00001000 )
#define BIT_13			( 0x00002000 )
#define BIT_14			( 0x00004000 )
#define BIT_15			( 0x00008000 )
#define BIT_16			( 0x00010000 )
#define BIT_17			( 0x00020000 )
#define BIT_18			( 0x00040000 )
#define BIT_19			( 0x00080000 )
#define BIT_20			( 0x00100000 )
#define BIT_21			( 0x00200000 )
#define BIT_22			( 0x00400000 )
#define BIT_23			( 0x00800000 )
#define BIT_24			( 0x01000000 )
#define BIT_25			( 0x02000000 )
#define BIT_26			( 0x04000000 )
#define BIT_27			( 0x08000000 )
#define BIT_28			( 0x10000000 )
#define BIT_29			( 0x20000000 )
#define BIT_30			( 0x40000000 )
#define BIT_31			( 0x80000000 )

/* General Purpose I/O */
#define GPBADDR			( 0x7E200000 )
#define GPIO00			( BIT_0 )
#define GPIO01			( BIT_1 )
#define GPIO02			( BIT_2 )
#define GPIO03			( BIT_3 )
#define GPIO04			( BIT_4 )
#define GPIO05			( BIT_5 )
#define GPIO06			( BIT_6 )
#define GPIO07			( BIT_7 )
#define GPIO08			( BIT_8 )
#define GPIO09			( BIT_9 )
#define GPIO10			( BIT_10 )
#define GPIO11			( BIT_11 )
#define GPIO12			( BIT_12 )
#define GPIO13			( BIT_13 )
#define GPIO14			( BIT_14 )
#define GPIO15			( BIT_15 )
#define GPIO16			( BIT_16 )
#define GPIO17			( BIT_17 )
#define GPIO18			( BIT_18 )
#define GPIO19			( BIT_19 )
#define GPIO20			( BIT_20 )
#define GPIO21			( BIT_21 )
#define GPIO22			( BIT_22 )
#define GPIO23			( BIT_23 )
#define GPIO24			( BIT_24 )
#define GPIO25			( BIT_25 )
#define GPIO26			( BIT_26 )
#define GPIO27			( BIT_27 )
#define GPIO28			( BIT_28 )
#define GPIO29			( BIT_29 )
#define GPIO30			( BIT_30 )
#define GPIO31			( BIT_31 )
#define GPIO32			( BIT_1 )
#define GPIO33			( BIT_2 )
#define GPIO34			( BIT_3 )
#define GPIO35			( BIT_4 )
#define GPIO36			( BIT_5 )
#define GPIO37			( BIT_6 )
#define GPIO38			( BIT_7 )
#define GPIO39			( BIT_8 )

/* GPIO Function Select */
#define GPFSEL0			( GPBADDR + 0x0000 )
#define GPFSEL1			( GPBADDR + 0x0004 )
#define GPFSEL2			( GPBADDR + 0x0008 )
#define GPFSEL3			( GPBADDR + 0x000C )
#define GPFSEL4			( GPBADDR + 0x0010 )
#define GPFSEL5			( GPBADDR + 0x0014 )
#define GPFIN			( 0x0000 )	//input
#define GPFOUT			( 0x0001 )	//output
#define GPF0			( 0x0100 )	//function 0
#define GPF1			( 0x0101 )	//function 1
#define GPF2			( 0x0110 )	//function 2
#define GPF3			( 0x0111 )	//function 3
#define GPF4			( 0x0011 )	//function 4
#define GPF5			( 0x0010 )	//function 5

/* GPIO Pin Output Set */
#define GPSET0			( GPBADDR + 0x001C )
#define GPSET1			( GPBADDR + 0x0020 )

/* GPIO Pin Output Clear */
#define GPCLR0			( GPBADDR + 0x0028 )
#define GPCLR1			( GPBADDR + 0x002C )

/* GPIO Pin Level */
#define GPLEV0			( GPBADDR + 0x0034 )
#define GPLEV1			( GPBADDR + 0x0038 )

/* GPIO Pin Event Detect Status */
#define GPEDS0			( GPBADDR + 0x0040 )
#define GPEDS1			( GPBADDR + 0x0044 )

/* GPIO Pin Rising Edge Detect Enable */
#define GPREN0			( GPBADDR + 0x004C )
#define GPREN1			( GPBADDR + 0x0050 )

/* GPIO Pin Falling Edge Detect Enable */
#define GPFEN0			( GPBADDR + 0x0058 )
#define GPFEN1			( GPBADDR + 0x005C )

/* GPIO Pin High Detect Enable */
#define GPHEN0			( GPBADDR + 0x0064 )
#define GPHEN1			( GPBADDR + 0x0068 )

/* GPIO Pin Low Detect Enable */
#define GPLEN0			( GPBADDR + 0x0070 )
#define GPLEN1			( GPBADDR + 0x0074 )

/* GPIO Pin Asyc. Rising Edge Detect */
#define GPAREN0			( GPBADDR + 0x007C )
#define GPAREN1			( GPBADDR + 0x0080 )

/* GPIO Pin Asyc. Falling Edge Detect */
#define GPAFEN0			( GPBADDR + 0x0088 )
#define GPAFEN1			( GPBADDR + 0x008C )

/* GPIO Pin Pull-up/Pull-down Enable */
#define GPPUD			( GPBADDR + 0x0094 )
#define GPPOFF			( 0x00 )
#define GPPDOWN			( 0x01 )
#define GPPUP			( 0x10 )

/* GPIO Pin Pull-up/Pull-down Enable Clock 0 */
#define GPPUDCLK0		( GPBADDR + 0x0098 )
#define GPPUDCLK1		( GPBADDR + 0x009C )

/* __GPIORASPPI3_H__ */
