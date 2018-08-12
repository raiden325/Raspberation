/*
 *	Hardware defnition for
 *	Raspberry Pi 3 model B & Raspberry Pi 2 model B
 *	Author:raiden325
 */
#ifndef __I2CRASPPI3_H__
#define __I2CRASPPI3_H__
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

/* __I2CRASPPI3_H__ */
