﻿namespace AdventOfCode;

internal static class Day7
{
    private const string input = "$ cd /\r\n$ ls\r\ndir dpbwg\r\ndir dvwfscw\r\ndir hccpl\r\ndir jsgbg\r\ndir lhjmzsl\r\n63532 mwvbpw.mmg\r\n239480 npj\r\ndir pngs\r\ndir qhs\r\n303649 shvgmwn.vhv\r\n236905 sjrrgd.phh\r\ndir sntcp\r\ndir sqs\r\n$ cd dpbwg\r\n$ ls\r\ndir dgh\r\n100731 dpbwg\r\ndir rpwnv\r\n$ cd dgh\r\n$ ls\r\n197049 lhjmzsl.hzj\r\n$ cd ..\r\n$ cd rpwnv\r\n$ ls\r\n10702 qsgv.fmf\r\n$ cd ..\r\n$ cd ..\r\n$ cd dvwfscw\r\n$ ls\r\ndir bvg\r\ndir fbfjs\r\n115450 gjftb.mgd\r\ndir gsmnprgz\r\ndir hdwdcvv\r\ndir mhjtrlqz\r\n75437 qsctddrw\r\n171722 qsgv.zqz\r\n$ cd bvg\r\n$ ls\r\n56335 cgtzb.szt\r\n139481 shvgmwn.vhv\r\n255200 wzqlgr.mhl\r\n$ cd ..\r\n$ cd fbfjs\r\n$ ls\r\n252977 hmcj\r\n256083 mbgfn.pmh\r\ndir qsgv\r\n$ cd qsgv\r\n$ ls\r\n271506 dchsdfz.bbg\r\n202650 hmcj\r\n32623 lqgmfcp\r\n57614 mgp.fbn\r\n220895 qwzqrrq.wjf\r\n$ cd ..\r\n$ cd ..\r\n$ cd gsmnprgz\r\n$ ls\r\ndir dzcsldzw\r\ndir hrjmfd\r\ndir lcwv\r\ndir sdp\r\n62355 zrncdmd.lmj\r\n$ cd dzcsldzw\r\n$ ls\r\ndir hmcj\r\n$ cd hmcj\r\n$ ls\r\n151947 hgtzldbg\r\n$ cd ..\r\n$ cd ..\r\n$ cd hrjmfd\r\n$ ls\r\ndir drjlhbqf\r\n65599 npj\r\n$ cd drjlhbqf\r\n$ ls\r\n263623 hzfmzs.mlj\r\n13866 npj\r\n173713 wtnf.qps\r\n$ cd ..\r\n$ cd ..\r\n$ cd lcwv\r\n$ ls\r\n44150 hmcj.lds\r\n200694 mpbb\r\n$ cd ..\r\n$ cd sdp\r\n$ ls\r\ndir gcwjj\r\ndir qzdczvwn\r\n$ cd gcwjj\r\n$ ls\r\n149603 qsgv.srr\r\n$ cd ..\r\n$ cd qzdczvwn\r\n$ ls\r\ndir gnvbm\r\n291187 hmcj.rgm\r\ndir msdt\r\ndir mwvbpw\r\ndir shpr\r\n$ cd gnvbm\r\n$ ls\r\n259516 dpbwg\r\n120868 mpbb\r\ndir vqrcd\r\n$ cd vqrcd\r\n$ ls\r\n306804 fqqg\r\n34290 mtctcdgd.nmb\r\n$ cd ..\r\n$ cd ..\r\n$ cd msdt\r\n$ ls\r\n168438 mpbb\r\n67435 nbqcrdjs\r\n$ cd ..\r\n$ cd mwvbpw\r\n$ ls\r\ndir btzqzvbl\r\n308719 npj\r\n$ cd btzqzvbl\r\n$ ls\r\n177311 bdnrf.jtw\r\n122356 qwhmd.vcd\r\n169153 vzzzccg.hlb\r\n$ cd ..\r\n$ cd ..\r\n$ cd shpr\r\n$ ls\r\n290591 nblzc.nmp\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd hdwdcvv\r\n$ ls\r\n96864 hmcj.tjn\r\n$ cd ..\r\n$ cd mhjtrlqz\r\n$ ls\r\ndir bzrbsfjp\r\n238772 fpggqqj\r\ndir hqzgs\r\n20155 shvgmwn.vhv\r\n$ cd bzrbsfjp\r\n$ ls\r\n313691 fnscbhfc\r\n17630 llwfdzgg.bsp\r\ndir lthr\r\n$ cd lthr\r\n$ ls\r\n237053 bhbbzt.bmt\r\n$ cd ..\r\n$ cd ..\r\n$ cd hqzgs\r\n$ ls\r\n295258 gllsgr.nnz\r\n70743 ptpqd\r\ndir rnmsdpmj\r\n205022 rpqh.rpn\r\n158287 tsm.tdq\r\n154025 wmfwr.bcm\r\n$ cd rnmsdpmj\r\n$ ls\r\n218043 dpbwg.mls\r\n149072 mbgfn.pmh\r\n89388 mwvbpw.qfm\r\n57207 rszcvm.mqc\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd hccpl\r\n$ ls\r\ndir blqdjh\r\ndir hfqw\r\ndir qsgv\r\n$ cd blqdjh\r\n$ ls\r\ndir fbpg\r\n$ cd fbpg\r\n$ ls\r\n231357 dpbwg\r\n$ cd ..\r\n$ cd ..\r\n$ cd hfqw\r\n$ ls\r\n210898 fjblghm.gtg\r\n286252 hmcj.dgz\r\n258768 mpbb\r\n225743 qsgv.pqf\r\n191717 shvgmwn.vhv\r\n$ cd ..\r\n$ cd qsgv\r\n$ ls\r\ndir bslqpr\r\ndir dpbwg\r\ndir lhjmzsl\r\n210707 npj\r\n64435 qhpnrbhq\r\ndir rpj\r\n301426 shvgmwn.vhv\r\ndir stbgbrw\r\ndir vhzmg\r\n$ cd bslqpr\r\n$ ls\r\n4365 dpbwg\r\ndir fpj\r\ndir lhjmzsl\r\ndir lncmt\r\ndir mwvbpw\r\n35725 ncbjtpcb.svf\r\ndir njhsmb\r\ndir rjzsddlw\r\n41533 shvgmwn.vhv\r\n$ cd fpj\r\n$ ls\r\n88146 dpbwg\r\n$ cd ..\r\n$ cd lhjmzsl\r\n$ ls\r\n57400 fzngdsh.sbn\r\n198711 mnqz.npt\r\n$ cd ..\r\n$ cd lncmt\r\n$ ls\r\n192228 qsgv.jss\r\n$ cd ..\r\n$ cd mwvbpw\r\n$ ls\r\n65217 hmcj.drs\r\n$ cd ..\r\n$ cd njhsmb\r\n$ ls\r\n157177 dpbwg.wsl\r\n10919 jhfs\r\n$ cd ..\r\n$ cd rjzsddlw\r\n$ ls\r\ndir cftp\r\ndir flcfwml\r\ndir vpdbl\r\n$ cd cftp\r\n$ ls\r\n89075 dpbwg\r\n57259 mbgfn.pmh\r\n237771 zwglrhh\r\n$ cd ..\r\n$ cd flcfwml\r\n$ ls\r\n51498 pbbgmqn.gfg\r\n$ cd ..\r\n$ cd vpdbl\r\n$ ls\r\n98690 npj\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd dpbwg\r\n$ ls\r\ndir wlmdbjh\r\n$ cd wlmdbjh\r\n$ ls\r\ndir pmldd\r\n245468 rdgldw.tzb\r\n$ cd pmldd\r\n$ ls\r\n145032 mwvbpw.tpc\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd lhjmzsl\r\n$ ls\r\n233642 dpbwg.tbq\r\ndir frsggjl\r\ndir hmcj\r\ndir jmhzlq\r\ndir jvdtpzd\r\n251765 npj\r\n169647 shvgmwn.vhv\r\n$ cd frsggjl\r\n$ ls\r\ndir dshv\r\ndir fqvpc\r\ndir lhjmzsl\r\n313045 npj\r\ndir rngqmwgr\r\n$ cd dshv\r\n$ ls\r\ndir pptfqn\r\n85609 wpgz\r\ndir zfmqls\r\n$ cd pptfqn\r\n$ ls\r\n258817 mtctcdgd.nmb\r\n39899 npj\r\n$ cd ..\r\n$ cd zfmqls\r\n$ ls\r\n119006 hlw.mzg\r\n295107 wstvdqn.wgw\r\n$ cd ..\r\n$ cd ..\r\n$ cd fqvpc\r\n$ ls\r\ndir pqpf\r\n$ cd pqpf\r\n$ ls\r\n312566 mpbb\r\n$ cd ..\r\n$ cd ..\r\n$ cd lhjmzsl\r\n$ ls\r\n157261 dpbwg.bgc\r\n76700 mpbb\r\n$ cd ..\r\n$ cd rngqmwgr\r\n$ ls\r\n42626 dpbwg.dtt\r\n78765 gjsnmzn.fzb\r\n$ cd ..\r\n$ cd ..\r\n$ cd hmcj\r\n$ ls\r\n166183 jntzn\r\ndir qsgv\r\n254851 rbcgrdr.vqp\r\n$ cd qsgv\r\n$ ls\r\n256449 dhj.mrm\r\n49207 fbrhl\r\n69922 lhjmzsl\r\n121778 tpdvnb\r\n$ cd ..\r\n$ cd ..\r\n$ cd jmhzlq\r\n$ ls\r\ndir bbpqsf\r\n245813 ftw.jwq\r\n$ cd bbpqsf\r\n$ ls\r\n169373 mwvbpw.tjt\r\n$ cd ..\r\n$ cd ..\r\n$ cd jvdtpzd\r\n$ ls\r\ndir brfln\r\ndir dpbwg\r\n263586 fsqzfhj.bzh\r\n85956 lhjmzsl\r\ndir mwvbpw\r\ndir tcgwhp\r\n91473 vjgt.twz\r\n200413 zlnnrrpn.qqd\r\n$ cd brfln\r\n$ ls\r\n65066 fpvnm\r\n$ cd ..\r\n$ cd dpbwg\r\n$ ls\r\ndir jtqwgc\r\ndir lrdjdqn\r\n281885 mpbb\r\n$ cd jtqwgc\r\n$ ls\r\n219022 spbqn\r\n$ cd ..\r\n$ cd lrdjdqn\r\n$ ls\r\n116830 hmcj.ptr\r\ndir mwvbpw\r\n$ cd mwvbpw\r\n$ ls\r\n251737 ccqlb\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd mwvbpw\r\n$ ls\r\n226329 fztjpfb\r\n$ cd ..\r\n$ cd tcgwhp\r\n$ ls\r\ndir grmsl\r\n$ cd grmsl\r\n$ ls\r\ndir hmcj\r\n197995 wzqlr.fqj\r\n$ cd hmcj\r\n$ ls\r\n239775 mbgfn.pmh\r\ndir rrvccjp\r\n95381 shvgmwn.vhv\r\n$ cd rrvccjp\r\n$ ls\r\ndir qsgv\r\n$ cd qsgv\r\n$ ls\r\n192956 mtctcdgd.nmb\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd rpj\r\n$ ls\r\ndir bwc\r\ndir ctjwjlzc\r\ndir dpbwg\r\ndir lhjmzsl\r\n249767 npj\r\ndir wqmlz\r\n$ cd bwc\r\n$ ls\r\n56181 hmcj.dhd\r\n105111 hvw\r\n63869 rqw.srq\r\n8030 shvgmwn.vhv\r\ndir stff\r\n$ cd stff\r\n$ ls\r\ndir gsjsc\r\n$ cd gsjsc\r\n$ ls\r\n514 mtctcdgd.nmb\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd ctjwjlzc\r\n$ ls\r\n39823 qjgnjm.hzn\r\n$ cd ..\r\n$ cd dpbwg\r\n$ ls\r\ndir lhqrjr\r\n$ cd lhqrjr\r\n$ ls\r\n179949 tmvl.zqf\r\n$ cd ..\r\n$ cd ..\r\n$ cd lhjmzsl\r\n$ ls\r\n305735 shvgmwn.vhv\r\n$ cd ..\r\n$ cd wqmlz\r\n$ ls\r\n141757 fstftggh\r\n$ cd ..\r\n$ cd ..\r\n$ cd stbgbrw\r\n$ ls\r\n196003 dpbwg.shs\r\ndir gbr\r\n104091 hmcj\r\n232145 lhjmzsl.nnc\r\ndir lhv\r\ndir qqqbtpq\r\n51208 qsgv.dbm\r\n235090 vbpzgnr\r\ndir vqmnsdrt\r\n$ cd gbr\r\n$ ls\r\n101809 npj\r\n121922 pcqrmmlt.ghh\r\n125915 ptffhc\r\n128293 wdz.nsd\r\n$ cd ..\r\n$ cd lhv\r\n$ ls\r\n75506 qtwlnvv.nbm\r\n28413 rbwbp\r\n$ cd ..\r\n$ cd qqqbtpq\r\n$ ls\r\n96300 gdf\r\n$ cd ..\r\n$ cd vqmnsdrt\r\n$ ls\r\n146229 mwvbpw.qrc\r\n189540 plldv.vtv\r\ndir rtng\r\n$ cd rtng\r\n$ ls\r\n42730 hrbs.zpc\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd vhzmg\r\n$ ls\r\ndir dcmjvhtt\r\ndir dpbwg\r\n$ cd dcmjvhtt\r\n$ ls\r\n85508 hhlctr.bbs\r\n296657 lhjmzsl.zjt\r\n255803 mbgfn.pmh\r\n170803 mtctcdgd.nmb\r\n$ cd ..\r\n$ cd dpbwg\r\n$ ls\r\n156142 hmcj\r\ndir lhjmzsl\r\n$ cd lhjmzsl\r\n$ ls\r\n13590 mtctcdgd.nmb\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd jsgbg\r\n$ ls\r\n202682 hmcj.tbl\r\n$ cd ..\r\n$ cd lhjmzsl\r\n$ ls\r\n197308 lhjmzsl\r\n$ cd ..\r\n$ cd pngs\r\n$ ls\r\n115979 hfpzqf.hjw\r\ndir lhjmzsl\r\n125414 mpbb\r\ndir mwbffchr\r\n$ cd lhjmzsl\r\n$ ls\r\n55108 hwhsjr\r\n$ cd ..\r\n$ cd mwbffchr\r\n$ ls\r\n249138 czv.lgd\r\n$ cd ..\r\n$ cd ..\r\n$ cd qhs\r\n$ ls\r\n108106 ccmhjzp.ppf\r\n197911 shvgmwn.vhv\r\n$ cd ..\r\n$ cd sntcp\r\n$ ls\r\ndir cvgtwsbw\r\ndir dpbwg\r\ndir dqbzfcq\r\ndir gfvtsjmz\r\ndir ljsmjsp\r\ndir mwvbpw\r\ndir phfqzwp\r\ndir rpsnfndl\r\ndir rrqwcbqm\r\ndir rtv\r\ndir vnvft\r\ndir vqcvbncp\r\ndir vsgjds\r\n$ cd cvgtwsbw\r\n$ ls\r\ndir bprbr\r\ndir bpw\r\ndir dpbwg\r\ndir jvjs\r\ndir mwvbpw\r\ndir nbfzn\r\ndir pcr\r\ndir rhgltw\r\n$ cd bprbr\r\n$ ls\r\n126107 dpbwg.jqq\r\n140931 ljhc.gsm\r\n120326 pnjv\r\ndir wbrb\r\n$ cd wbrb\r\n$ ls\r\n28887 ccr.rvd\r\ndir gwfpgws\r\n77898 mwvbpw.qrc\r\n280487 pbfbtb.qjp\r\n$ cd gwfpgws\r\n$ ls\r\n205904 dgm\r\n313203 vpgzr.jfw\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd bpw\r\n$ ls\r\ndir lgstpgrn\r\n173334 npj\r\n$ cd lgstpgrn\r\n$ ls\r\ndir rngr\r\n$ cd rngr\r\n$ ls\r\n291856 czjz.fzp\r\n246123 mpbb\r\n200301 qqfvpnz\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd dpbwg\r\n$ ls\r\n265739 mtctcdgd.nmb\r\ndir mwvbpw\r\n76505 ntjn.mnp\r\n227157 pqznms\r\n312879 qzlmsht\r\n$ cd mwvbpw\r\n$ ls\r\n144523 dpbwg.lgr\r\n39441 mmtrnzqw.mnv\r\n285772 mpbb\r\n306936 rpmgcmqd.qht\r\n$ cd ..\r\n$ cd ..\r\n$ cd jvjs\r\n$ ls\r\n51134 lsnvhd.gsj\r\n$ cd ..\r\n$ cd mwvbpw\r\n$ ls\r\n125428 hmcj.bvd\r\n40162 npj\r\n117658 pmzfj.crj\r\n$ cd ..\r\n$ cd nbfzn\r\n$ ls\r\n11429 mwvbpw.swl\r\n5582 qsgv.jrm\r\n$ cd ..\r\n$ cd pcr\r\n$ ls\r\ndir dpbwg\r\n95858 mtctcdgd.nmb\r\n$ cd dpbwg\r\n$ ls\r\ndir wmsb\r\n$ cd wmsb\r\n$ ls\r\n154498 npj\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd rhgltw\r\n$ ls\r\n188447 qsgv.rzs\r\n$ cd ..\r\n$ cd ..\r\n$ cd dpbwg\r\n$ ls\r\n261326 cjfszwr\r\n88528 glp.fgc\r\ndir lhjmzsl\r\n270470 shvgmwn.vhv\r\n310081 vdhmgb\r\ndir wsc\r\n$ cd lhjmzsl\r\n$ ls\r\n245410 dnnfljbs\r\n$ cd ..\r\n$ cd wsc\r\n$ ls\r\ndir lhjmzsl\r\n311302 mbs.tqc\r\n309985 mpbb\r\ndir qgpqzr\r\n20812 vhcc.wpw\r\n$ cd lhjmzsl\r\n$ ls\r\ndir dpbwg\r\n$ cd dpbwg\r\n$ ls\r\n273340 fmvbcphl.crp\r\n$ cd ..\r\n$ cd ..\r\n$ cd qgpqzr\r\n$ ls\r\ndir fdwgdhrf\r\n$ cd fdwgdhrf\r\n$ ls\r\n275421 mtctcdgd.nmb\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd dqbzfcq\r\n$ ls\r\n30930 njnz\r\n$ cd ..\r\n$ cd gfvtsjmz\r\n$ ls\r\n290134 mbgfn.pmh\r\n154689 vql\r\n$ cd ..\r\n$ cd ljsmjsp\r\n$ ls\r\n59894 hwggw.rpd\r\n26336 mbgfn.pmh\r\ndir mvzchpq\r\ndir mwvbpw\r\n122061 zlcr.jsw\r\n$ cd mvzchpq\r\n$ ls\r\n294618 lhjmzsl.bqm\r\ndir mwvbpw\r\n204294 nljhbh.cfc\r\n79337 ntvt.dbw\r\n$ cd mwvbpw\r\n$ ls\r\ndir njwcqcjh\r\n309971 nqdv.vmp\r\n$ cd njwcqcjh\r\n$ ls\r\n155159 mtctcdgd.nmb\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd mwvbpw\r\n$ ls\r\n43451 lhjmzsl.vjt\r\n$ cd ..\r\n$ cd ..\r\n$ cd mwvbpw\r\n$ ls\r\n3144 phvjzs.prf\r\n$ cd ..\r\n$ cd phfqzwp\r\n$ ls\r\ndir hmcj\r\ndir hnnrw\r\n196279 lhjmzsl\r\n90948 mwvbpw.hvm\r\n275082 shvgmwn.vhv\r\n$ cd hmcj\r\n$ ls\r\n4346 mtctcdgd.nmb\r\n$ cd ..\r\n$ cd hnnrw\r\n$ ls\r\ndir lhjmzsl\r\n103070 qsbrf.tpv\r\ndir rdf\r\n$ cd lhjmzsl\r\n$ ls\r\n158692 dpbwg.bvl\r\n$ cd ..\r\n$ cd rdf\r\n$ ls\r\ndir gpj\r\ndir lbgpm\r\n$ cd gpj\r\n$ ls\r\n136508 shvgmwn.vhv\r\n$ cd ..\r\n$ cd lbgpm\r\n$ ls\r\n154457 ccpvr\r\n232065 lhjmzsl\r\n43787 npj\r\n189920 rpgmvv\r\n96362 tlmvpc\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd rpsnfndl\r\n$ ls\r\ndir pcbtmcwf\r\n$ cd pcbtmcwf\r\n$ ls\r\ndir qsgv\r\n$ cd qsgv\r\n$ ls\r\n45662 npj\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd rrqwcbqm\r\n$ ls\r\ndir vjm\r\n$ cd vjm\r\n$ ls\r\n263137 npj\r\n$ cd ..\r\n$ cd ..\r\n$ cd rtv\r\n$ ls\r\ndir lhjmzsl\r\ndir pcwsn\r\ndir qsgv\r\ndir vvzbsg\r\n$ cd lhjmzsl\r\n$ ls\r\ndir qzsjhsfn\r\n$ cd qzsjhsfn\r\n$ ls\r\n26909 mbgfn.pmh\r\n$ cd ..\r\n$ cd ..\r\n$ cd pcwsn\r\n$ ls\r\n160033 ftz.nbg\r\n145165 wgdjsgsb.hhm\r\n$ cd ..\r\n$ cd qsgv\r\n$ ls\r\ndir jqm\r\n136209 mbgfn.pmh\r\n79664 mghdlnh.chv\r\n$ cd jqm\r\n$ ls\r\n222831 npj\r\n$ cd ..\r\n$ cd ..\r\n$ cd vvzbsg\r\n$ ls\r\n84246 dpbwg.tsq\r\n$ cd ..\r\n$ cd ..\r\n$ cd vnvft\r\n$ ls\r\ndir crqrl\r\ndir scdvzsd\r\n$ cd crqrl\r\n$ ls\r\n13185 dpbwg.twz\r\n109021 qcdqnhg.jjj\r\n$ cd ..\r\n$ cd scdvzsd\r\n$ ls\r\ndir hmcj\r\n$ cd hmcj\r\n$ ls\r\n252155 npj\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd vqcvbncp\r\n$ ls\r\n72128 crnhb\r\ndir ddz\r\ndir dvhzvdn\r\ndir ffsbcmg\r\ndir gfs\r\ndir jghlb\r\ndir llq\r\ndir pvn\r\ndir rvqmmjgr\r\n$ cd ddz\r\n$ ls\r\n232302 gdfqpnj.nhf\r\n274940 lhjmzsl.mzv\r\n286217 mpbb\r\n$ cd ..\r\n$ cd dvhzvdn\r\n$ ls\r\n273183 cfnqn.qpz\r\n$ cd ..\r\n$ cd ffsbcmg\r\n$ ls\r\n6544 mtctcdgd.nmb\r\n52511 wndzt.lqb\r\n$ cd ..\r\n$ cd gfs\r\n$ ls\r\n228312 mwvbpw.tdj\r\ndir rqjrfzgt\r\n62100 shc.rtj\r\n313984 szsplzq.dpd\r\ndir tqtnp\r\n$ cd rqjrfzgt\r\n$ ls\r\n296460 bvp\r\n272324 mbgfn.pmh\r\n221044 npj\r\n110232 qvcszzv\r\n$ cd ..\r\n$ cd tqtnp\r\n$ ls\r\n98376 tzwh\r\n212247 wzjj.scp\r\n$ cd ..\r\n$ cd ..\r\n$ cd jghlb\r\n$ ls\r\ndir ddrmsv\r\n$ cd ddrmsv\r\n$ ls\r\n252143 mbgfn.pmh\r\n$ cd ..\r\n$ cd ..\r\n$ cd llq\r\n$ ls\r\ndir lhjmzsl\r\n67341 mbgfn.pmh\r\n155159 npj\r\ndir qsgv\r\ndir vcvnzc\r\n$ cd lhjmzsl\r\n$ ls\r\n151930 ssldrsf.mzm\r\n$ cd ..\r\n$ cd qsgv\r\n$ ls\r\n233702 ztdmtqb.mhf\r\n$ cd ..\r\n$ cd vcvnzc\r\n$ ls\r\n168179 lhjmzsl.cwf\r\n$ cd ..\r\n$ cd ..\r\n$ cd pvn\r\n$ ls\r\n240160 lbd.slf\r\n$ cd ..\r\n$ cd rvqmmjgr\r\n$ ls\r\n24809 gwgcrzp.zhj\r\ndir hmcj\r\ndir lhjmzsl\r\ndir mwvbpw\r\n121997 nbmf\r\n77886 ntp\r\ndir qcqrgdm\r\n$ cd hmcj\r\n$ ls\r\n126073 dpbwg.lhh\r\ndir jchccghv\r\ndir lhjmzsl\r\n144075 qsgv.lbw\r\n288076 swrngbsq.qzw\r\n$ cd jchccghv\r\n$ ls\r\n310277 mpbb\r\n$ cd ..\r\n$ cd lhjmzsl\r\n$ ls\r\n193576 bwsz.crv\r\n16002 mbgfn.pmh\r\n57961 mtctcdgd.nmb\r\n$ cd ..\r\n$ cd ..\r\n$ cd lhjmzsl\r\n$ ls\r\ndir bsfwmcz\r\ndir dpbwg\r\n121640 mwvbpw\r\ndir pmrfvzw\r\ndir qsgv\r\n$ cd bsfwmcz\r\n$ ls\r\ndir fjqqblz\r\n51952 gqbj.fwd\r\ndir hmcj\r\ndir lctt\r\n81316 lhjmzsl.qqr\r\n6372 mbgfn.pmh\r\n22669 shvgmwn.vhv\r\n130990 zgq.fpv\r\n$ cd fjqqblz\r\n$ ls\r\n26064 zrqrnb.nwf\r\n$ cd ..\r\n$ cd hmcj\r\n$ ls\r\n14385 mwvbpw.vzq\r\n$ cd ..\r\n$ cd lctt\r\n$ ls\r\n137397 fbgbs.fjf\r\ndir jgbzqzq\r\ndir qrr\r\n272639 qsgv.vwm\r\n$ cd jgbzqzq\r\n$ ls\r\n135320 mpbb\r\n$ cd ..\r\n$ cd qrr\r\n$ ls\r\ndir dpbwg\r\ndir mwvbpw\r\n54143 pnsl.bbm\r\ndir wbpzpg\r\n$ cd dpbwg\r\n$ ls\r\n250653 shvgmwn.vhv\r\n$ cd ..\r\n$ cd mwvbpw\r\n$ ls\r\n2682 fhdh.hmt\r\n$ cd ..\r\n$ cd wbpzpg\r\n$ ls\r\ndir bqshqpvm\r\n141398 mtctcdgd.nmb\r\n130729 vtnfmjqm.mgp\r\n$ cd bqshqpvm\r\n$ ls\r\n252449 shvgmwn.vhv\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd dpbwg\r\n$ ls\r\n82216 gwjwmcbf.gwl\r\n$ cd ..\r\n$ cd pmrfvzw\r\n$ ls\r\ndir mwvbpw\r\ndir wtzgjspz\r\ndir zmb\r\n$ cd mwvbpw\r\n$ ls\r\n16736 wbzjzz.mqq\r\n$ cd ..\r\n$ cd wtzgjspz\r\n$ ls\r\ndir vjb\r\n$ cd vjb\r\n$ ls\r\n301763 drchphtm\r\n$ cd ..\r\n$ cd ..\r\n$ cd zmb\r\n$ ls\r\n201978 mdj\r\ndir qgnffw\r\n147889 qzbmwpnm.gjp\r\n$ cd qgnffw\r\n$ ls\r\n17740 cwz.dhs\r\n222345 mbgfn.pmh\r\n81554 npj\r\n206597 tsnlnzh\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd qsgv\r\n$ ls\r\ndir mmsnzr\r\n$ cd mmsnzr\r\n$ ls\r\n160502 tgrztm\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd mwvbpw\r\n$ ls\r\n40049 qmmdv\r\n313418 qsgv.srp\r\n$ cd ..\r\n$ cd qcqrgdm\r\n$ ls\r\n202848 wtl.qbj\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd vsgjds\r\n$ ls\r\n138690 npj\r\n22984 tpfbnz.sgj\r\n$ cd ..\r\n$ cd ..\r\n$ cd sqs\r\n$ ls\r\ndir zms\r\n$ cd zms\r\n$ ls\r\n152096 cvtqph.wwp\r\ndir mmwzg\r\n$ cd mmwzg\r\n$ ls\r\n100870 qsgv";

    public static void Part1()
    {
        var tree = GetFileTree(input);
        var folders = tree.GetAllFolders();
        var res = folders
            .Where(f => f.Size <= 100000)
            .Sum(f => f.Size);

        Console.WriteLine(res);
    }

    public static void Part2()
    {
        var tree = GetFileTree(input);
        var folders = tree.GetAllFolders();
        var freeSpace = 70000000 - tree.Size;
        var needToFree = 30000000 - freeSpace;
        var res = folders
            .Where(f => f.Size >= needToFree)
            .Min(f => f.Size);
        Console.WriteLine(res);
    }

    private static Folder GetFileTree(string input)
    {
        var root = new Folder { Name = "/" };
        var currentFolder = root;
        var commands = input.Split("\r\n");
        foreach (var cmd in commands)
        {
            var parts = cmd.Split(" ");
            if (parts[0] == "$" && parts[1] == "cd")
            {
                if (parts[2] == "/")
                {
                    currentFolder = root;
                }
                else if (parts[2] == "..")
                {
                    currentFolder = currentFolder.Parent;
                }
                else
                {
                    currentFolder = currentFolder
                        .Files
                        .OfType<Folder>()
                        .Single(f => f.Name == parts[2]);
                }
            }
            else if (parts[0] == "dir")
            {
                currentFolder.Files.Add(new Folder { Name = parts[1], Parent = currentFolder });
            }
            else if (int.TryParse(parts[0], out var size))
            {
                currentFolder.Files.Add(new File { Parent = currentFolder, Size = size, Name = parts[1] });
            }
        }
        return root;
    }

    public record Folder : File
    {
        public List<File> Files = new();
        public override int Size { get { return Files.Sum(f => f.Size); } }
        public IEnumerable<Folder> GetAllFolders()
        {
            var res = new List<Folder>(Files.OfType<Folder>());
            foreach (var f in Files.OfType<Folder>())
            {
                res.AddRange(f.GetAllFolders());
            }
            return res.Distinct();
        }
    }

    public record File
    {
        public string Name { get; set; }
        public virtual int Size { get; set; }
        public Folder Parent { get; set; }
    }
}