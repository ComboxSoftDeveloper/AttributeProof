## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFADACEFB10]; AttributeProof.Subjects.StackWithInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,3FDE0B4D1D3
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       add       rax,0F
       shr       rax,4
       add       rsp,20
M01_L00:
       push      0
       push      0
       dec       rax
       jne       short M01_L00
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       dec       ecx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       r8,3FDE0B4D1D3
       cmp       [rbp+8],r8
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFADAB57D50]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 128
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithoutInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFADACFFAF8]; AttributeProof.Subjects.StackWithoutInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithoutInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,0D963457CF03E
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       mov       rdx,rax
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,20
       neg       rdx
       add       rdx,rsp
       jb        short M01_L00
       xor       edx,edx
M01_L00:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M01_L00
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       dec       ecx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       r8,0D963457CF03E
       cmp       [rbp+8],r8
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFADAB67D50]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 153
```

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFACEB6CE58]; AttributeProof.Subjects.StackWithInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,43A9773C0824
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       add       rax,0F
       shr       rax,4
       add       rsp,20
M01_L00:
       push      0
       push      0
       dec       rax
       jne       short M01_L00
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,43A9773C0824
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFACE8FE9D0]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 135
```

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithoutInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFACEB4CC00]; AttributeProof.Subjects.StackWithoutInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithoutInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,0F3BF7B5ABD01
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       mov       rdx,rax
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,20
       neg       rdx
       add       rdx,rsp
       jb        short M01_L00
       xor       edx,edx
M01_L00:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M01_L00
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,0F3BF7B5ABD01
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFACE8DE9D0]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 160
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFACF07EB08]; AttributeProof.Subjects.StackWithInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,18C57478139F
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       add       rax,0F
       shr       rax,4
       add       rsp,20
M01_L00:
       push      0
       push      0
       dec       rax
       jne       short M01_L00
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,18C57478139F
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFACEED7798]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 135
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithoutInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFACF05EB08]; AttributeProof.Subjects.StackWithoutInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithoutInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,72C4BE7E1C57
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       mov       rdx,rax
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,20
       neg       rdx
       add       rdx,rsp
       jb        short M01_L00
       xor       edx,edx
M01_L00:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M01_L00
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,72C4BE7E1C57
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFACEEB7798]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 160
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFADAD1FB10]; AttributeProof.Subjects.StackWithInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,0F684F768497A
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       add       rax,0F
       shr       rax,4
       add       rsp,20
M01_L00:
       push      0
       push      0
       dec       rax
       jne       short M01_L00
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       dec       ecx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       r8,0F684F768497A
       cmp       [rbp+8],r8
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFADAB87D50]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 128
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithoutInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFADAD0FB10]; AttributeProof.Subjects.StackWithoutInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithoutInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,63E31DD2B730
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       mov       rdx,rax
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,20
       neg       rdx
       add       rdx,rsp
       jb        short M01_L00
       xor       edx,edx
M01_L00:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M01_L00
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       dec       ecx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       r8,63E31DD2B730
       cmp       [rbp+8],r8
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFADAB77D50]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 153
```

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFACEB5CE58]; AttributeProof.Subjects.StackWithInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,0BB36D387A557
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       add       rax,0F
       shr       rax,4
       add       rsp,20
M01_L00:
       push      0
       push      0
       dec       rax
       jne       short M01_L00
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,0BB36D387A557
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFACE8EE9D0]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 135
```

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithoutInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFACEB4CE70]; AttributeProof.Subjects.StackWithoutInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithoutInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,5A10457ADADE
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       mov       rdx,rax
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,20
       neg       rdx
       add       rdx,rsp
       jb        short M01_L00
       xor       edx,edx
M01_L00:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M01_L00
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,5A10457ADADE
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFACE8DE9D0]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 160
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFACF07EB08]; AttributeProof.Subjects.StackWithInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,6D5A83DF3A57
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       add       rax,0F
       shr       rax,4
       add       rsp,20
M01_L00:
       push      0
       push      0
       dec       rax
       jne       short M01_L00
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,6D5A83DF3A57
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFACEED7798]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 135
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithoutInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFACF04EB08]; AttributeProof.Subjects.StackWithoutInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithoutInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,573C10A393E2
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       mov       rdx,rax
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,20
       neg       rdx
       add       rdx,rsp
       jb        short M01_L00
       xor       edx,edx
M01_L00:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M01_L00
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,573C10A393E2
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFACEEA7798]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 160
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFADAD1FB10]; AttributeProof.Subjects.StackWithInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,0AF64156CBA6
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       add       rax,0F
       shr       rax,4
       add       rsp,20
M01_L00:
       push      0
       push      0
       dec       rax
       jne       short M01_L00
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       dec       ecx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       r8,0AF64156CBA6
       cmp       [rbp+8],r8
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFADAB87D50]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 128
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithoutInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFADAD0FB10]; AttributeProof.Subjects.StackWithoutInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithoutInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,0A3A4C5AE3278
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       mov       rdx,rax
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,20
       neg       rdx
       add       rdx,rsp
       jb        short M01_L00
       xor       edx,edx
M01_L00:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M01_L00
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       dec       ecx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       r8,0A3A4C5AE3278
       cmp       [rbp+8],r8
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFADAB77D50]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 153
```

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFACEB4CBE8]; AttributeProof.Subjects.StackWithInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,498C20F55F98
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       add       rax,0F
       shr       rax,4
       add       rsp,20
M01_L00:
       push      0
       push      0
       dec       rax
       jne       short M01_L00
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,498C20F55F98
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFACE8DE9D0]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 135
```

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithoutInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFACEB4CE70]; AttributeProof.Subjects.StackWithoutInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithoutInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,0BF9D0B12C579
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       mov       rdx,rax
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,20
       neg       rdx
       add       rdx,rsp
       jb        short M01_L00
       xor       edx,edx
M01_L00:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M01_L00
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,0BF9D0B12C579
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFACE8DE9D0]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 160
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFACEA8EB08]; AttributeProof.Subjects.StackWithInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,0E1573FCB812C
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       add       rax,0F
       shr       rax,4
       add       rsp,20
M01_L00:
       push      0
       push      0
       dec       rax
       jne       short M01_L00
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,0E1573FCB812C
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFACE8E7798]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 135
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithoutInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFACEA8EB08]; AttributeProof.Subjects.StackWithoutInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithoutInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,7BA178A79A7D
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       mov       rdx,rax
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,20
       neg       rdx
       add       rdx,rsp
       jb        short M01_L00
       xor       edx,edx
M01_L00:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M01_L00
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,7BA178A79A7D
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFACE8E7798]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 160
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFADACFFA20]; AttributeProof.Subjects.StackWithInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,405897950BC9
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       add       rax,0F
       shr       rax,4
       add       rsp,20
M01_L00:
       push      0
       push      0
       dec       rax
       jne       short M01_L00
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       dec       ecx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       r8,405897950BC9
       cmp       [rbp+8],r8
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFADAB67D50]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 128
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithoutInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFADACEFB10]; AttributeProof.Subjects.StackWithoutInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithoutInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,23A5BAA8965C
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       mov       rdx,rax
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,20
       neg       rdx
       add       rdx,rsp
       jb        short M01_L00
       xor       edx,edx
M01_L00:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M01_L00
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       dec       ecx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       r8,23A5BAA8965C
       cmp       [rbp+8],r8
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFADAB57D50]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 153
```

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFACEB5CBE8]; AttributeProof.Subjects.StackWithInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,1685E2881A04
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       add       rax,0F
       shr       rax,4
       add       rsp,20
M01_L00:
       push      0
       push      0
       dec       rax
       jne       short M01_L00
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,1685E2881A04
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFACE8EE9D0]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 135
```

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithoutInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFACEB4CE70]; AttributeProof.Subjects.StackWithoutInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithoutInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,0BE7F8F729289
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       mov       rdx,rax
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,20
       neg       rdx
       add       rdx,rsp
       jb        short M01_L00
       xor       edx,edx
M01_L00:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M01_L00
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,0BE7F8F729289
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFACE8DE9D0]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 160
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFACEA7EB08]; AttributeProof.Subjects.StackWithInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,44785E01EA1F
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       add       rax,0F
       shr       rax,4
       add       rsp,20
M01_L00:
       push      0
       push      0
       dec       rax
       jne       short M01_L00
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,44785E01EA1F
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFACE8D7798]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 135
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithoutInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFACEA6EBC8]; AttributeProof.Subjects.StackWithoutInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithoutInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,0BE5CB1B9C039
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       mov       rdx,rax
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,20
       neg       rdx
       add       rdx,rsp
       jb        short M01_L00
       xor       edx,edx
M01_L00:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M01_L00
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,0BE5CB1B9C039
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFACE8C7798]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 160
```

