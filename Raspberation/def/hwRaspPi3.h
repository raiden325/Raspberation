/*
 *	Hardware defnition for
 *	Raspberry Pi 3 model B & Raspberry Pi 2 model B
 *	Author:raiden325
 */
#ifndef __HWRASPPI3_H__
#define __HWRASPPI3_H__
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

/* PCM/I2C Audio */
#define PCMBADDR		( 0x7E203000 )

/* PCM Control and Status */
#define PCMCS_A			( PCMBADDR + 0x0000 )
#define PCMCSEN			( BIT_0 )
#define PCMCSRXON		( BIT_1 )
#define PCMCSTXON		( BIT_2 )
#define PCMCSTXCLR		( BIT_3 )
#define PCMCSRXCLR		( BIT_4 )
#define PCMCSTXTHREMP	( 0x00 << 5 )
#define PCMCSTXTHRNEMP	( 0x01 << 5 )
#define PCMCSTXTHRFULL	( 0x03 << 5 )
#define PCMCSRXTHREMP	( 0x00 << 7 )
#define PCMCSRXTHRNEMP	( 0x01 << 7 )
#define PCMCSRXTHRFULL	( 0x03 << 7 )
#define PCMCSDMAEN		( BIT_9 )
#define PCMCSTXSYNC		( BIT_13 )
#define PCMCSRXSYNC		( BIT_14 )
#define PCMCSTXERR		( BIT_15 )
#define PCMCSRXERR		( BIT_16 )
#define PCMCSTXW		( BIT_17 )
#define PCMCSRXR		( BIT_18 )
#define PCMCSTXD		( BIT_19 )
#define PCMCSRXD		( BIT_20 )
#define PCMCSTXE		( BIT_21 )
#define PCMCSRXE		( BIT_22 )
#define PCMCSRXSEX		( BIT_23 )
#define PCMCSSYNC		( BIT_24 )
#define PCMCSSTBY		( BIT_25 )

/* PCM FIFO Data */
#define PCMFIFO_A		( PCMBADDR + 0x0004 )

/* PCM Mode */
#define PCMMODE_A		( PCMBADDR + 0x0008 )
#define PCMMFSLEN( c )	( c )
#define PCMMFLEN( c )	( c << 10 )
#define PCMMFSI			( BIT_20 )
#define PCMMFSM			( BIT_21 )
#define PCMMCLKI		( BIT_22 )
#define PCMMCLKM		( BIT_23 )
#define PCMMFTXP		( BIT_24 )
#define PCMMFRXP		( BIT_25 )
#define PCMMPDME		( BIT_26 )
#define PCMMPDMN		( BIT_27 )
#define PCMMCLK_DIS		( BIT_28 )

/* PCM Receive Configuration */
#define PCMRXC_A		( PCMBADDR + 0x000C )
#define PCMRCH2WID( c )	( c )
#define PCMRCH2POS( c )	( c << 4 )
#define PCMRCH2EN		( BIT_14 )
#define PCMRCH2WEN		( BIT_15 )
#define PCMRCH1WID( c )	( c << 16 )
#define PCMRCH1POS( c )	( c << 20 )
#define PCMRCH1EN		( BIT_30 )
#define PCMRCH1WEN		( BIT_31 )

/* PCM Transmit Configuration */
#define PCMTXC_A		( PCMBADDR + 0x0010 )
#define PCMTCH2WID( c )	( c )
#define PCMTCH2POS( c )	( c << 4 )
#define PCMTCH2EN		( BIT_14 )
#define PCMTCH2WEN		( BIT_15 )
#define PCMTCH1WID( c )	( c << 16 )
#define PCMTCH1POS( c )	( c << 20 )
#define PCMTCH1EN		( BIT_30 )
#define PCMTCH1WEN		( BIT_31 )

/* PCM DMA Request Level */
#define PCMDREQ_A		( PCMBADDR + 0x0014 )
#define PCMDRX( c )		( c )
#define PCMDTX( c )		( c << 8 )
#define PCMDRXP( c )	( c << 16 )
#define PCMDTXP( c )	( c << 24 )

/* PCM Interrupt Enables */
#define PCMINTEN_A		( PCMBADDR + 0x0018 )
#define PCMIENTXW		( BIT_0 )
#define PCMIENRXR		( BIT_1 )
#define PCMIENTXERR		( BIT_2 )
#define PCMIENRXERR		( BIT_3 )

/* PCM Interrupt Status & Clear */
#define PCMINTSTC_A		( PCMBADDR + 0x001C )
#define PCMISTCTXW		( BIT_0 )
#define PCMISTCRXR		( BIT_1 )
#define PCMISTCTXERR	( BIT_2 )
#define PCMISTCRXERR	( BIT_3 )

/* PCM Gray Mode Control */
#define PCMGRAY			( PCMBADDR + 0x0020 )
#define PCMGEN			( BIT_0 )
#define PCMGCLR			( BIT_1 )
#define PCMGFLUSH		( BIT_2 )
#define PCMGRXL( c )	( c << 4 )
#define PCMGFED( c )	( c << 10 )
#define PCMGRXFL( c )	( c << 16 )

/* __HWRASPPI3_H__ */
