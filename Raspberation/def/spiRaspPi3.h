/*
 *	Hardware defnition for
 *	Raspberry Pi 3 model B & Raspberry Pi 2 model B
 *	Author:raiden325
 */
#ifndef __SPIRASPPI3_H__
#define __SPIRASPPI3_H__
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

/* SPI 1 Control register 0 */
#define AUXS0CTL0		( AUXBADDR + 0x0080 )
#define AUXSSLN( c )	( c )
#define AUXSMSB			( BIT_6 )
#define AUXSINVCLK		( BIT_7 )
#define AUXSORSNG		( BIT_8 )
#define AUXSCLRFIFO		( BIT_9 )
#define AUXSIRSNG		( BIT_10 )
#define AUXSEN			( BIT_11 )
#define AUXSDOUTH0		( 0x00 << 12 )
#define AUXSDOUTH1		( 0x01 << 12 )
#define AUXSDOUTH4		( 0x02 << 12 )
#define AUXSDOUTH7		( 0x03 << 12 )
#define AUXSVALWD		( BIT_14 )
#define AUXSVALCS		( BIT_15 )
#define AUXSPSTINM		( BIT_16 )
#define AUXSCSEL( c )	( c << 17 )
#define AUXSSPD( c )	( c << 20 )

/* SPI 1 Control register 1 */
#define AUXS0CTL1		( AUXBADDR + 0x0084 )
#define AUXSKPIN		( BIT_0 )
#define AUXSSMSB		( BIT_1 )
#define AUXSDIRQ		( BIT_6 )
#define AUXSTXEMPIRQ	( BIT_7 )
#define AUXSCSHT( c )	( c << 8 )

/* SPI 1 Status */
#define AUXS0STAT		( AUXBADDR + 0x0088 )
#define AUXSBCNT( c )	( c )
#define AUXSBSY			( BIT_6 )
#define AUXSRXEMP		( BIT_2 )
#define AUXSTXEMP		( BIT_3 )
#define AUXSTXFULL		( BIT_4 )
#define AUXSRXFL( c )	( c << 12 )
#define AUXSTXFL( c )	( c << 24 )

/* SPI 1 Data */
#define AUXS0IO			( AUXBADDR + 0x0090 )

/* SPI 1 Peek */
#define AUXS0PEEK		( AUXBADDR + 0x0094 )
#define AUXSPDATA( c )	( c )

/* SPI 1 I/O */
#define AUXS0IO			( AUXBADDR + 0x00A0 )
#define AUXSIODATA( c )	( c )

/* SPI 1 TX Hold */
#define AUXS0TXHOLD		( AUXBADDR + 0x00B0 )
#define AUXSTXHDAT( c )	( c )

/* SPI 2 Control register 0 */
#define AUXS1CTL0		( AUXBADDR + 0x00C0 )

/* SPI 2 Control register 1 */
#define AUXS1CTL1		( AUXBADDR + 0x00C4 )

/* SPI 2 Status */
#define AUXS1STAT		( AUXBADDR + 0x00C8 )

/* SPI 2 Data */
#define AUXS1IO			( AUXBADDR + 0x00D0 )

/* SPI 2 Peek */
#define AUXS1PEEK		( AUXBADDR + 0x00D4 )

/* SPI 2 I/O */
#define AUXS1IO			( AUXBADDR + 0x00E0 )

/* SPI 2 TX Hold */
#define AUXS1TXHOLD		( AUXBADDR + 0x00F0 )

/* __SPIRASPPI3_H__ */
