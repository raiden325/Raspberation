/*
 *	Hardware defnition for
 *	Raspberry Pi 3 model B & Raspberry Pi 2 model B
 *	Author:raiden325
 */
#ifndef __UARTRASPPI3_H__
#define __UARTRASPPI3_H__
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

/* Auxiliaries: UART1 & SPI1, SPI2 */
#define AUXBADDR		( 0x7E215000 )

/* Auxiliary Interrupt status */
#define AUXIRQ			( AUXBADDR + 0x0000 )
#define AUXMUIRQ		( BIT_0 )
#define AUXS0IRQ		( BIT_1 )
#define AUXS1IRQ		( BIT_2 )

/* Auxiliary enables */
#define AUXEN			( AUXBADDR + 0x0004 )
#define AUXMUEN			( BIT_0 )
#define AUXS0EN			( BIT_1 )
#define AUXS1EN			( BIT_2 )

/* Mini Uart I/O Data */
#define AUXMUIO			( AUXBADDR + 0x0040 )
#define AUXMUTX			( AUXMUIO )
#define AUXMURX			( AUXMUIO )

/* Mini Uart Interrupt Enable */
#define AUXMUIER		( AUXBADDR + 0x0044 )
#define AUXMUTXE		( BIT_0 )
#define AUXMURXE		( BIT_1 )

/* Mini Uart Interrupt Identify */
#define AUXMUIIR		( AUXBADDR + 0x0048 )
#define AUXMUNOIRPT		( 0x00 << 1 )
#define AUXMUTXH		( 0x01 << 1)
#define AUXMURXH		( 0x02 << 1 )

/* Mini Uart Line Control */
#define AUXMULCR		( AUXBADDR + 0x004C )
#define AUXMUDS8		( BIT_0 )
#define AUXMUBFERR		( BIT_6 )
#define AUXMUDLAB		( BIT_7 )

/* Mini Uart Modem Control */
#define AUXMUMCR		( AUXBADDR + 0x0050 )
#define AUXMURTS		( BIT_1 )

/* Mini Uart Line Status */
#define AUXMULSR		( AUXBADDR + 0x0054 )
#define AUXMUSTDR		( BIT_0 )
#define AUXMUSTROR		( BIT_1 )
#define AUXMUSTTEMP		( BIT_5 )
#define AUXMUSTTIDL		( BIT_6 )

/* Mini Uart Modem Status */
#define AUXMUMSR		( AUXBADDR + 0x0058 )
#define AUXMUSTCTS		( BIT_5 )

/* Mini Uart Scratch */
#define AUXMUSRT		( AUXBADDR + 0x005C )

/* Mini Uart Extra Control */
#define AUXMUCTL		( AUXBADDR + 0x0060 )
#define AUXMURXEN		( BIT_0 )
#define AUXMUTXEN		( BIT_1 )
#define AUXMURTSEN		( BIT_2 )
#define AUXMUCTSEN		( BIT_3 )
#define AUXMURTSFL3		( 0x00 << 4 )
#define AUXMURTSFL2		( 0x01 << 4 )
#define AUXMURTSFL1		( 0x02 << 4 )
#define AUXMURTSFL4		( 0x03 << 4 )
#define AUXMURTSAL		( BIT_6 )
#define AUXMUCTSAL		( BIT_7 )

/* Mini Uart Extra Status */
#define AUXMUSTAT		( AUXBADDR + 0x0064 )
#define AUXMUSBLA		( BIT_0 )
#define AUXMUSPA		( BIT_1 )
#define AUXMURIDL		( BIT_2 )
#define AUXMUTIDL		( BIT_3 )
#define AUXMUROR		( BIT_4 )
#define AUXMUTFF		( BIT_5 )
#define AUXMURTSST		( BIT_6 )
#define AUXMUCTSL		( BIT_7 )
#define AUXMUTFE		( BIT_8 )
#define AUXMUTDN		( BIT_9 )
#define AUXMURFL( c )	( c << 16 )
#define AUXMUTFL( c )	( c << 24 )

/* Mini Uart Baudrate */
#define AUXMUBAUD		( AUXBADDR + 0x0068 )

/* __UARTRASPPI3_H__ */
